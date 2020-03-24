import { Component, OnInit } from '@angular/core';

import { AuthentificationService } from '../../../services/authentification.service';
import { NotificationService } from '../../../services/notification.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit{
  isExpanded = false;

  constructor(
    private authService: AuthentificationService,
    private notificationService: NotificationService,
    private authentificationService: AuthentificationService
  ) {}

  logout() {
    this.notificationService.createNotification(2, "Good Bye", 'success', 'Success')
    this.authentificationService.logout();
  }

  collapse() {
    this.isExpanded = false;
  } 

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  ngOnInit() {
  }
  isAuthentificated() {
    return this.authService.isAuthentificated();
  }
  isAdmin() {
    return this.authService.isAdmin();
  }
}
