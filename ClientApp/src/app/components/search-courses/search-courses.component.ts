import { Component, OnInit } from '@angular/core';

import { CoursesService } from '../../services/courses.service';
import { CoursesList } from '../../interfaces/courseListInterfaces';
import { NotificationService } from '../../services/notification.service';

@Component({
  selector: 'search-courses',
  templateUrl: './search-courses.component.html',
  styleUrls: ['./search-courses.component.css']
})


export class SearchCoursesComponent implements OnInit {

  allCourses: CoursesList;
  coursesCount: number;
  pageNumber: number = 1;
  pageSize: number = 6;

  constructor(
    private notificationService: NotificationService,
    private courseService: CoursesService,
  ) {}

  ngOnInit() {
    this.getAllCourses();
    if (!history.state.isSubscribedOnCourses && history.state.isSubscribedOnCourses !== undefined) {
      this.notificationService.createNotification(0, 'You have not yet enrolled in any course, please select a course and subscribe to start studyng',
        'warning', 'Start your training');
    }
  }

  getAllCourses() {
    this.courseService.getAllCourses()
      .subscribe(
        requestData => {
          this.coursesCount = requestData.length
          this.allCourses = requestData;
        },
        error => {
          console.log(error);
        });
  }

  changePage(pageNumber: number) {
    this.pageNumber = pageNumber;
  }
}
