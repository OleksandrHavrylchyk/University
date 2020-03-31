import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';

import { AuthentificationService } from '../../services/authentification.service'


@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',

  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit{

  registerForm: FormGroup;
  loading = false;
  submitted = false;
  errorOnSubmit;
  
  constructor(
    private authService: AuthentificationService,
    private formBuilder: FormBuilder,
    private router: Router,
  ) {}

  ngOnInit() {
    this.registerForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      userName: ['', [Validators.required, Validators.pattern('^[a-zA-Z]+$')]],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }

  get f() { return this.registerForm.controls; }

  onSubmit() {
    this.submitted = true;

    if (this.registerForm.invalid) {
      return;
    }

    this.loading = true;
    this.authService.register(this.registerForm.value)
      .pipe(first())
      .subscribe(
        data => {
          this.router.navigate(['/send-activation'], {
            state: { userRegisterData: this.registerForm.value }
          });
        },
        error => {
          this.errorOnSubmit = error.error;
          this.loading = false;
        });
  }
}
