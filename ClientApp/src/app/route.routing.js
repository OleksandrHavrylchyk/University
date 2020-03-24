"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var home_component_1 = require("./components/home/home.component");
var registration_component_1 = require("./components/registration/registration.component");
var send_activation_component_1 = require("./components/send-activation/send-activation.component");
var login_component_1 = require("./components/login/login.component");
var search_courses_component_1 = require("./components/search-courses/search-courses.component");
var admin_dashboard_component_1 = require("./components/admin-dashboard/admin-dashboard.component");
var admin_guard_1 = require("./guards/admin.guard");
exports.appRoutes = [
    {
        path: '', component: home_component_1.HomeComponent,
        children: []
    },
    { path: 'sign-up', component: registration_component_1.RegistrationComponent },
    { path: 'courses', component: search_courses_component_1.SearchCoursesComponent },
    { path: 'send-activation', component: send_activation_component_1.SendActivationComponent },
    { path: 'sign-in', component: login_component_1.LoginComponent },
    { path: 'admin-dashboard', component: admin_dashboard_component_1.AdminDashboardComponent, canActivate: [admin_guard_1.AdminGuard] },
    { path: 'admin-dashboard/:pageNumber:pageSize', component: admin_dashboard_component_1.AdminDashboardComponent, canActivate: [admin_guard_1.AdminGuard] },
    { path: 'admin-dashboard/:pageNumber:pageSize:search', component: admin_dashboard_component_1.AdminDashboardComponent, canActivate: [admin_guard_1.AdminGuard] },
    { path: '**', redirectTo: '', pathMatch: 'full' }
];
//# sourceMappingURL=route.routing.js.map