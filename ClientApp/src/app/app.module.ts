import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { NzGridModule } from 'ng-zorro-antd/grid'
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { NzFormModule } from 'ng-zorro-antd/form';
import { NzAlertModule } from 'ng-zorro-antd/alert';
import { NzNotificationModule } from 'ng-zorro-antd/notification';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { HeaderComponent } from './components/Layout/header/header.component'
import { FooterComponent } from './components/Layout/footer/footer.component'
import { RegistrationComponent } from './components/registration/registration.component'
import { SendActivation } from './components/send-activation/send-activation.component';
import { LoginComponent } from './components/login/login.component';
import { appRoutes } from './route.routing';

@NgModule({
  declarations: [ 
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    RegistrationComponent,
    SendActivation,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    NzButtonModule,
    NzIconModule,
    NzFormModule,
    NzGridModule,
    NzAlertModule,
    BrowserAnimationsModule,
    NzNotificationModule,
    RouterModule.forRoot(appRoutes)
  ],
  /*providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],*/
  bootstrap: [AppComponent]
})
export class AppModule { }
