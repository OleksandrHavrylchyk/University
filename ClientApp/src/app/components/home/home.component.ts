import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { CoursesService } from '../../services/courses.service';
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
  displaySubscribeModal: boolean = false;
  subscribedCourseId: number;

  constructor(
    private router: Router,
    private courseService: CoursesService,
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

  specifyDate(courseId: number) {
    if (this.authentificationService.isAuthentificated()) {
      this.displaySubscribeModal = true;
      this.subscribedCourseId = courseId;
    }
    else {
      this.notificationService.createNotification(2, 'You have sing in to subscribe on course', 'warning', 'Warning');
    }
  }
}
