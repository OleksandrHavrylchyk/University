import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';


@Injectable({
  providedIn: 'root'
})

export class UserManageService {
  private baseUrl = environment.apiUrl;

  constructor(
    private http: HttpClient,
  ) { }

  putUserData(userData: any) {

    return this.http.put<any>(this.baseUrl + 'update-user', userData)
  }
}
