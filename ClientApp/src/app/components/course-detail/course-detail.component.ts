import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CoursesService } from '../../services/courses.service';
import { NotificationService } from '../../services/notification.service';


@Component({
  selector: 'course-detail',
  templateUrl: './course-detail.component.html',
  styleUrls: ['./course-detail.component.css']
})

export class CourseDetailComponent implements OnInit {
  courseData: any;

  constructor(
    private activatedRoute: ActivatedRoute,
    private courseService: CoursesService,
    private notificationService: NotificationService
  ) { }

  ngOnInit(){
    this.activatedRoute.url.subscribe(url => {
      if (Object.keys(url).length) {
        this.getCourseInfo(url[url.length - 1].path ? url[url.length - 1].path : undefined);
      }
    })
  }

  getCourseInfo(courseUrl: string) {
    this.courseService.getCourseInfo(courseUrl)
      .subscribe(
        requestData => {
          this.courseData = requestData[0];
        },
        error => {
          this.notificationService.createNotification(2, 'Cannot get information about course', 'error', 'Error');
          console.log(error);
        });
  }
}
