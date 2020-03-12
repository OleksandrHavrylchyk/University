"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var home_component_1 = require("./components/home/home.component");
var registration_component_1 = require("./components/registration/registration.component");
var send_activation_component_1 = require("./components/send-activation/send-activation.component");
var login_component_1 = require("./components/login/login.component");
var search_courses_component_1 = require("./components/search-courses/search-courses.component");
var admin_dashboard_component_1 = require("./components/admin-dashboard/admin-dashboard.component");
exports.appRoutes = [
    {
        path: '', component: home_component_1.HomeComponent,
        children: []
    },
    { path: 'sign-up', component: registration_component_1.RegistrationComponent },
    { path: 'courses', component: search_courses_component_1.SearchCoursesComponent },
    { path: 'send-activation', component: send_activation_component_1.SendActivation },
    { path: 'sign-in', component: login_component_1.LoginComponent },
    { path: 'admin-dashboard', component: admin_dashboard_component_1.AdminDashboardComponent /*, canActivate: [AdminGuard]*/ },
    { path: 'admin-dashboard/:pageNumber:pageSize', component: admin_dashboard_component_1.AdminDashboardComponent /*, canActivate: [AdminGuard]*/ },
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