import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService as SocialAuthService, FacebookLoginProvider } from 'angularx-social-login';

import { AuthentificationService } from '../../services/authentification.service';
import { FacebookAuthUser } from '../../models/user';


@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  messageOnLoginError: string;
  userFacebookData = new FacebookAuthUser();
  currentDate = new Date().getTime();
  errorOnLogin = false;

  constructor(
    private authServiceFacebook: SocialAuthService,
    private authService: AuthentificationService,
    private formBuilder: FormBuilder,
    private router: Router,
  ) { }

  loginWithFB() {
    this.authServiceFacebook.signIn(FacebookLoginProvider.PROVIDER_ID).then((response) => {
      this.userFacebookData.userName = response.firstName + response.lastName + this.currentDate;
      this.userFacebookData.email = response.email;
      this.userFacebookData.name = response.firstName;
      this.userFacebookData.lastName = response.lastName;
      this.userFacebookData.token = response.authToken;
      this.authService.facebookLogin(this.userFacebookData)
        .subscribe(
          data => {
            if (!data.isSubscribedOncourses) {
              this.router.navigate(['/courses'], {
                state: { isSubscribedOnCourses: false }
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
            this.messageOnLoginError = error.error;
          });
    });
  }

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
          if (!data.isSubscribedOncourses) {
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
