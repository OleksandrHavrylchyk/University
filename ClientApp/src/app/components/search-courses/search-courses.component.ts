import { Component, OnInit } from '@angular/core';
import { NzNotificationService } from 'ng-zorro-antd/notification';

import { CoursesService } from '../../services/courses.service';
import { CoursesList } from '../../interfaces/courseListInterfaces';

@Component({
  selector: 'search-courses',
  templateUrl: './search-courses.component.html',
  styleUrls: ['./search-courses.component.css']
})


export class SearchCoursesComponent implements OnInit {

  allCourses: CoursesList;

  constructor(
    private notification: NzNotificationService,
    private courseService: CoursesService,
  ) {}

  ngOnInit() {
    this.getAllCourses();
    console.log(history.state.isSubscribedOnCourses);
    if (!history.state.isSubscribedOnCourses && history.state.isSubscribedOnCourses !== undefined) {
      this.createNotification();
    }
  }

  getAllCourses() {
    this.courseService.getAllCourses()
      .subscribe(
        requestData => {
          this.allCourses = requestData;
        },
        error => {
          console.log(error);
        });
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
