import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { AuthentificationService } from './authentification.service';


@Injectable({
  providedIn: 'root'
})

export class UserManageService {
  private baseUrl = environment.apiUrl;

  constructor(
    private http: HttpClient,
    private authentificationService: AuthentificationService,
  ) { }

  putUserData(userData: any) {
    var requestHeader = this.authentificationService.getAuthorizationHeader();
    return this.http.put<any>(this.baseUrl + 'update-user', userData, { headers: requestHeader })
  }
}
