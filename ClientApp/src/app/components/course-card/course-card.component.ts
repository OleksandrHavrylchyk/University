import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'course-card',
  templateUrl: './course-card.component.html',
  styleUrls: ['./course-card.component.css']
})

export class CourseCardComponent  {

  @Input() courseInfo: any;

  constructor(
    private router: Router,
  ) { }

  redirectToCoursePage(courseUrl: string) {
    this.router.navigate([`/course/${courseUrl}`]);
  }
}

