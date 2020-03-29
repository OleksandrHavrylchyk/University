import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { AuthentificationService } from './authentification.service';


@Injectable({
  providedIn: 'root'
})

export class CoursesService {
  private baseUrl = environment.apiUrl;

  constructor(
    private http: HttpClient,
    private authentificationService: AuthentificationService
  ) { }

  getNewCourses() {
    return this.http.get<any>(`${this.baseUrl}new-courses/`)
  }

  getAllCourses() {
    return this.http.get<any>(`${this.baseUrl}courses/`)
  }

  getCourseInfo(courseUrl: string) {
    return this.http.get<any>(`${this.baseUrl}course/${courseUrl}`)
  }

  getAdminDashboardCourses() {
    var requestHeader = this.authentificationService.getAuthorizationHeader();
    return this.http.get<any>(`${this.baseUrl}admin-dasboard-courses/`, { headers: requestHeader })
  }
}
