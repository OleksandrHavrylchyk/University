import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { NzNotificationService } from 'ng-zorro-antd/notification';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {


  constructor(
    private router: Router,
    private notification: NzNotificationService,
  ) {
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
    if (!history.state.isLoggedIn && history.state.isLoggedIn !== undefined) {
      this.createNotification();
    }
  }
}
