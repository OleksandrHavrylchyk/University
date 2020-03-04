import { Component, OnInit } from '@angular/core';

import { AuthentificationService } from '../../../services/authentification.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit{
  isExpanded = false;
  isAuthentificated = false;
  isAdmin = false;

  constructor(
    private authService: AuthentificationService,
  ) {
  }

  collapse() {
    this.isExpanded = false;
  } 

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  ngOnInit() {
    this.isAuthentificated = this.authService.isAuthentificated();
    this.isAdmin = this.authService.isAdmin();
  }
}
