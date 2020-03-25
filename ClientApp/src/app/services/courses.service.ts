import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';


@Injectable({
  providedIn: 'root'
})

export class CoursesService {
  private baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getNewCourses() {
    return this.http.get<any>(`${this.baseUrl}new-courses/`)
  }

  getAllCourses() {
    return this.http.get<any>(`${this.baseUrl}courses/`)
  }

  getCourseInfo(courseUrl: string) {
    return this.http.get<any>(`${this.baseUrl}course/${courseUrl}`)
  }
}
