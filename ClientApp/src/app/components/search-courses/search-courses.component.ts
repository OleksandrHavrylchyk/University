import { Component, OnInit } from '@angular/core';
import { NzNotificationService } from 'ng-zorro-antd/notification';

@Component({
  selector: 'search-courses',
  templateUrl: './search-courses.component.html',
  styleUrls: ['./search-courses.component.css']
})
export class SearchCoursesComponent implements OnInit {
  constructor(
    private notification: NzNotificationService
  ) {}

  ngOnInit() {
    if (!history.state.isSubscribedOnCourses && history.state.isSubscribedOnCourses !== undefined) {
      this.createNotification();
    }
  }

  createNotification(): void {
    this.notification.config({
      nzPlacement: 'bottomRight'
    });
    this.notification.create(
      'warning',
      'Start your training',
      'You have not yet enrolled in any course, please select a course and subscribe to start studyng',
      { nzDuration: 0 },
    );
  }
}
