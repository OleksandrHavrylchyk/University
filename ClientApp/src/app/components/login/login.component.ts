import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

import { AuthentificationService } from '../../services/authentification.service';


@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  errorOnLogin = false;
  messageOnLoginError: string

  constructor(
    private authService: AuthentificationService,
    private formBuilder: FormBuilder,
    private router: Router,
  ) {}

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      userName: [''],
      password: ['']
    });
  }
  onLoginSubmit() {
    this.authService.login(this.loginForm.value)
      .subscribe(
        data => {
          if (!data.isSubscribedOnCourses) {
            this.router.navigate(['/courses'], {
              state: { isSubscribedOnCourses: false}
            });
          }
          else {
            this.router.navigate(['/'], {
              state: { isLoggedIn: true }
            });
          }
        },
        error => {
          this.errorOnLogin = true;
          this.messageOnLoginError = "Invalid email or user name";
        });
  }
}
