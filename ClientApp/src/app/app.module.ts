import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { JwtModule } from '@auth0/angular-jwt';
import { NzInputModule } from 'ng-zorro-antd/input';
import { NzAvatarModule } from 'ng-zorro-antd/avatar';
import { NzTableModule } from 'ng-zorro-antd/table';
import { NzCardModule } from 'ng-zorro-antd/card';
import { NzGridModule } from 'ng-zorro-antd/grid'
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { NzFormModule } from 'ng-zorro-antd/form';
import { NzAlertModule } from 'ng-zorro-antd/alert';
import { NzPaginationModule } from 'ng-zorro-antd/pagination';
import { NzSelectModule } from 'ng-zorro-antd/select';
import { NzNotificationModule } from 'ng-zorro-antd/notification';
import { NzModalModule } from 'ng-zorro-antd/modal';
import { NzDatePickerModule } from 'ng-zorro-antd/date-picker';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { HeaderComponent } from './components/Layout/header/header.component';
import { FooterComponent } from './components/Layout/footer/footer.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { SendActivation } from './components/send-activation/send-activation.component';
import { CourseCardComponent } from './components/course-card/course-card.component';
import { LoginComponent } from './components/login/login.component';
import { SearchCoursesComponent } from './components/search-courses/search-courses.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { StartDatePickerComponent } from './components/start-date-picker/start-date-picker.component';
import { appRoutes } from './route.routing';
import { environment } from '../environments/environment';

export function tokenGetter() {
  return sessionStorage.getItem('token');
}

@NgModule({
  declarations: [ 
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    RegistrationComponent,
    SendActivation,
    LoginComponent,
    CourseCardComponent,
    SearchCoursesComponent,
    AdminDashboardComponent,
    StartDatePickerComponent
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
    NzCardModule,
    NzAvatarModule,
    NzTableModule,
    NzPaginationModule,
    NzSelectModule,
    NzInputModule,
    NzModalModule,
    NzDatePickerModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        whitelistedDomains: [environment.providerUrl],
        blacklistedRoutes: [environment.apiUrl + 'login']
      }
    }),
    RouterModule.forRoot(appRoutes)
  ],
  /*providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],*/
  bootstrap: [AppComponent]
})
export class AppModule { }
