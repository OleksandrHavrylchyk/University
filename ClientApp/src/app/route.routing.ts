import { Routes } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { SendActivationComponent } from './components/send-activation/send-activation.component';
import { LoginComponent } from './components/login/login.component';
import { SearchCoursesComponent } from './components/search-courses/search-courses.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';

import { AdminGuard } from './guards/admin.guard';
import { CourseDetailComponent } from './components/course-detail/course-detail.component';


export const appRoutes: Routes = [
  {
    path: '', component: HomeComponent,
    children:
      [
      ]
  },
  { path: 'sign-up', component: RegistrationComponent },
  { path: 'courses', component: SearchCoursesComponent },
  { path: 'send-activation', component: SendActivationComponent },
  { path: 'sign-in', component: LoginComponent },
  { path: 'admin-dashboard', component: AdminDashboardComponent, canActivate: [AdminGuard]},
  { path: 'admin-dashboard/:pageNumber:pageSize', component: AdminDashboardComponent, canActivate: [AdminGuard] },
  { path: 'admin-dashboard/:pageNumber:pageSize:search', component: AdminDashboardComponent, canActivate: [AdminGuard] },
  { path: 'course/:courseUrl', component: CourseDetailComponent },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];
