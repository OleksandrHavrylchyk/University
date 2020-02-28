import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class UserService {
  private baseUrl = environment.apiUrl + 'login/';
  constructor(private http: HttpClient) { }

  register(user: User) {
    return this.http.post(this.baseUrl, user);
  }
}
