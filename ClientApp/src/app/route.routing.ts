import { Routes } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { RegistrationComponent } from './components/registration/registration.component';

export const appRoutes: Routes = [
  {
    path: '', component: HomeComponent,
  },
  //{ path: 'sign-in', component: LoginComponent },
  { path: 'sign-up', component: RegistrationComponent },
  /*{
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
    ]
  },*/
  // if somebody comes in a random root'
  { path: '**', redirectTo: '', pathMatch: 'full' }
];
