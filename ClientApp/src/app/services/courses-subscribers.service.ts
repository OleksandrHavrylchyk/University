import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { AuthentificationService } from './authentification.service';


@Injectable({
  providedIn: 'root'
})

export class CoursesSubscribersService {
  private baseUrl = environment.apiUrl;

  constructor(
    private http: HttpClient,
    private authentificationService: AuthentificationService,
  ) { }

  postCourseSubscriber(courseId: number, studyDate: string) {
    var requestHeader = this.authentificationService.getAuthorizationHeader();
    return this.http.post<any>(`${this.baseUrl}subscribe-course`, { courseId: courseId, studyDate: studyDate }, { headers: requestHeader })
  }

  getNumberOfCourseSubscribers(courseId: number) {
    return this.http.get<any>(`${this.baseUrl}course-subscribers/${courseId}`)
  }
}
