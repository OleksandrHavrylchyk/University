import { Component, OnInit } from '@angular/core';

import { AuthentificationService } from '../../../services/authentification.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit{
  isExpanded = false;

  constructor(
    private authService: AuthentificationService,
  ) {
  }

  logout() {
    sessionStorage.removeItem("token");
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
