"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var home_component_1 = require("./components/home/home.component");
var registration_component_1 = require("./components/registration/registration.component");
exports.appRoutes = [
    {
        path: '', component: home_component_1.HomeComponent,
    },
    //{ path: 'sign-in', component: LoginComponent },
    { path: 'sign-up', component: registration_component_1.RegistrationComponent },
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
//# sourceMappingURL=route.routing.js.map