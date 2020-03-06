import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NzNotificationService } from 'ng-zorro-antd/notification';

import { CoursesService } from '../../services/courses.service';
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
    private notification: NzNotificationService,
    private courseService: CoursesService,
  ) { }

  ngOnInit() {
    this.getHomeCourses();
    if (!history.state.isLoggedIn && history.state.isLoggedIn !== undefined) {
      this.createNotification();
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

  createNotification(): void {
    this.notification.config({
      nzPlacement: 'bottomRight'
    });
    this.notification.create(
      'success',
      'Success',
      'You successfully authorized',
      { nzDuration: 2 },
    );
  }

  routeCourses() {
    this.router.navigate(['/courses']);
  }
}
