import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { AuthentificationService } from './authentification.service';


@Injectable({
  providedIn: 'root'
})

export class UserListService {
  private baseUrl = environment.apiUrl;

  constructor(
    private http: HttpClient,
    private authentificationService: AuthentificationService,
  ) { }

  getPageOfUsers(pageNumber: string, pageSize: string) {
    return this.http.get<any>(this.baseUrl + 'get-users/', { params: { pageNumber: pageNumber, pageSize: pageSize }})
  }
}
