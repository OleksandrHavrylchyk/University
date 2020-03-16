import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { CoursesService } from '../../services/courses.service';
import { CoursesSubscribersService } from '../../services/courses-subscribers.service';
import { NotificationService } from '../../services/notification.service';
import { AuthentificationService } from '../../services/authentification.service';
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
    private authentificationService: AuthentificationService,
  ) { }

  ngOnInit() {
    this.getHomeCourses();
    if (history.state.isLoggedIn) {
      this.notificationService.createNotification(2, 'You successfully authorized', 'success', 'Success');
    }
  }

  getHomeCourses() {
    this.courseService.getNewCourses()
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
          this.notificationService.createNotification(2, 'You registered on course', 'success', 'Success');
        },
        error => {
          if (!this.authentificationService.isAuthentificated()) {
            this.notificationService.createNotification(2, 'You have sing in to subscribe on course', 'warning', 'Warning');
          }
          else {
            this.notificationService.createNotification(2, error.error, 'warning', 'Warning');
          }
        });
  }
}
