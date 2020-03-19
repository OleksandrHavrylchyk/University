import { Component, Input, EventEmitter, Output, OnInit } from '@angular/core';
import { en_US, NzI18nService } from 'ng-zorro-antd/i18n';
import { differenceInCalendarDays } from 'date-fns';

import { CoursesSubscribersService } from '../../services/courses-subscribers.service';
import { NotificationService } from '../../services/notification.service';
import { AuthentificationService } from '../../services/authentification.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'start-date-picker',
  templateUrl: './start-date-picker.component.html',
  styleUrls: ['./start-date-picker.component.css'],
  providers: [DatePipe]
})
export class StartDatePickerComponent implements OnInit {

  modalHeight: string = "140px";
  courseStartDate: Date;
  currentDay = new Date();

  @Input() displayModal: boolean;
  @Input() courseId: number;
  @Output() displayModalChange = new EventEmitter<boolean>();

  constructor(
    private i18n: NzI18nService,
    private coursesSubscribersService: CoursesSubscribersService,
    private notificationService: NotificationService,
    private authentificationService: AuthentificationService,
    private datePipe: DatePipe
  ) { }

  hideModal() {
    this.displayModalChange.emit(false);
  }

  disabledDate = (selected: Date): boolean => {
    return differenceInCalendarDays(selected, this.currentDay) < 0;
  };

  changeHeightOnOpen(isOpen: any) {
    this.modalHeight = isOpen ? "400px" : "140px";
  }

  onChange(startDate: Date): void {
    this.courseStartDate = startDate;
  }

  ngOnInit() {
    this.i18n.setLocale(en_US);
  }

  subscribeCourse() {
    this.coursesSubscribersService.postCourseSubscriber(this.courseId, this.datePipe.transform(this.courseStartDate, 'dd/MM/yyyy HH:mm:ss'))
      .subscribe(
      data => {
          this.notificationService.createNotification(2, 'You registered on course', 'success', 'Success');
          this.hideModal();
      },
      error => {
        if (!this.authentificationService.isAuthentificated()) {
          this.notificationService.createNotification(2, 'You have sing in to subscribe on course', 'warning', 'Warning');
        }
        else if (error.status == 400) {
          this.notificationService.createNotification(2, error.error, 'warning', "Warning" );
        }
        else {
          console.log(error);
        }
      });
  }
}
