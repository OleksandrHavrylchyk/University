import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CoursesService } from '../../services/courses.service';
import { NotificationService } from '../../services/notification.service';
import { AuthentificationService } from '../../services/authentification.service';
import { CoursesSubscribersService } from '../../services/courses-subscribers.service';


@Component({
  selector: 'course-detail',
  templateUrl: './course-detail.component.html',
  styleUrls: ['./course-detail.component.css']
})

export class CourseDetailComponent implements OnInit {
  courseData: any;
  displaySubscribeModal: boolean = false;
  subscribedCourseId: number;
  numberOfSubscribers: number = 0;

  constructor(
    private activatedRoute: ActivatedRoute,
    private courseService: CoursesService,
    private notificationService: NotificationService,
    private authentificationService: AuthentificationService,
    private courseSubscribersService: CoursesSubscribersService,
  ) { }

  ngOnInit(){
    this.activatedRoute.url.subscribe(url => {
      if (Object.keys(url).length) {
        this.getCourseInfo(url[url.length - 1].path ? url[url.length - 1].path : undefined);
      }
    })
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

  getNumberOfSubscribers(courseId: number) {
    this.courseSubscribersService.getNumberOfCourseSubscribers(courseId)
      .subscribe(
        requestData => {
          this.numberOfSubscribers = requestData.numberOfSubscribers
        },
        error => {
          console.log(error);
        });
  }

  getCourseInfo(courseUrl: string) {
    this.courseService.getCourseInfo(courseUrl)
      .subscribe(
        requestData => {
          this.courseData = requestData[0];
          this.getNumberOfSubscribers(this.courseData.id);
        },
        error => {
          this.notificationService.createNotification(2, 'Cannot get information about course', 'error', 'Error');
          console.log(error);
        });
  }
}
