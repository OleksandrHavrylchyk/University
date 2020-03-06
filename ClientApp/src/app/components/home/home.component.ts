import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { CoursesService } from '../../services/courses.service';
import { CoursesSubscribersService } from '../../services/courses-subscribers.service';
import { NotificationService } from '../../services/notification.service';
import { CoursesList } from '../../interfaces/courseListInterfaces';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  homeCourses: CoursesList;

  constructor(
    private router: Router,
    private courseService: CoursesService,
    private coursesSubscribersService: CoursesSubscribersService,
    private notificationService: NotificationService,
  ) { }

  ngOnInit() {
    this.getHomeCourses();
    if (history.state.isLoggedIn) {
      this.notificationService.createNotification(2, 'You successfully authorized');
    }
  }

  getHomeCourses() {
    this.courseService.getCoursesAboutBegin()
      .subscribe(
        data => {
          this.homeCourses = data;
        },
        error => {
          console.log(error);
        });
  }

  routeCourses() {
    this.router.navigate(['/courses']);
  }

  subscribeCourse(id: number) {
    this.coursesSubscribersService.postCourseSubscriber(id)
      .subscribe(
        data => {
          this.notificationService.createNotification(2,'You registered on course');
        },
        error => {
          console.log(error);
        });
  }
}
