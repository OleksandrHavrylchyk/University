import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { IconDefinition } from '@ant-design/icons-angular';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SocialLoginModule, AuthServiceConfig, FacebookLoginProvider } from 'angularx-social-login';
import { RouterModule } from '@angular/router';
import { JwtModule } from '@auth0/angular-jwt';
import { NzInputModule } from 'ng-zorro-antd/input';
import { NzDropDownModule } from 'ng-zorro-antd/dropdown';
import { NzTabsModule } from 'ng-zorro-antd/tabs';
import { NzAvatarModule } from 'ng-zorro-antd/avatar';
import { NzTableModule } from 'ng-zorro-antd/table';
import { NzCardModule } from 'ng-zorro-antd/card';
import { NzGridModule } from 'ng-zorro-antd/grid'
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzIconModule, NZ_ICON_DEFAULT_TWOTONE_COLOR, NZ_ICONS } from 'ng-zorro-antd/icon';
import { FacebookOutline } from '@ant-design/icons-angular/icons';
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
import { SendActivationComponent } from './components/send-activation/send-activation.component';
import { CourseCardComponent } from './components/course-card/course-card.component';
import { LoginComponent } from './components/login/login.component';
import { SearchCoursesComponent } from './components/search-courses/search-courses.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { StartDatePickerComponent } from './components/start-date-picker/start-date-picker.component';
import { CourseDetailComponent } from './components/course-detail/course-detail.component';
import { appRoutes } from './route.routing';
import { environment } from '../environments/environment';
import { RefreshTokenInterceptor } from './helpers/refresh-token.interceptor';

export function tokenGetter() {
  return localStorage.getItem('token');
}

const config = new AuthServiceConfig([
  {
    id: FacebookLoginProvider.PROVIDER_ID,
    provider: new FacebookLoginProvider('2814753781954441')
  }
]);

const icons: IconDefinition[] = [FacebookOutline];

export function provideConfig() {
  return config;
}

@NgModule({
  declarations: [ 
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    RegistrationComponent,
    SendActivationComponent,
    LoginComponent,
    CourseCardComponent,
    SearchCoursesComponent,
    AdminDashboardComponent,
    StartDatePickerComponent,
    CourseDetailComponent
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
    SocialLoginModule,
    NzTabsModule,
    NzDropDownModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        whitelistedDomains: [environment.providerUrl],
        blacklistedRoutes: [environment.apiUrl + 'login']
      }
    }),
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    { provide: NZ_ICON_DEFAULT_TWOTONE_COLOR, useValue: '#00ff00' },
    { provide: NZ_ICONS, useValue: icons },
    {
      provide: AuthServiceConfig,
      useFactory: provideConfig
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: RefreshTokenInterceptor,
      multi: true 
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
