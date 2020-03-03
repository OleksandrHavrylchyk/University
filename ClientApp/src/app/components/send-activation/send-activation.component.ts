import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { first } from 'rxjs/operators';

import { UserService } from '../../services/authentification.service'

@Component({
  selector: 'send-activation',
  templateUrl: './send-activation.component.html',
  styleUrls: ['./send-activation.component.css']
})
export class SendActivation {

  constructor(
    private authService: UserService,
  ) {
  }
  sendActivation() {
      this.authService.sendConfirmationEmail(history.state.userRegisterData)
      .pipe(first())
      .subscribe(
        error => {
          console.error(error);
        });
  }
}
