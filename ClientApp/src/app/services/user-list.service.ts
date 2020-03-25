import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { AuthentificationService } from './authentification.service';


@Injectable({
  providedIn: 'root'
})

export class UserListService {
  private baseUrl = environment.apiUrl;
  private params = {};

  constructor(
    private http: HttpClient,
    private authentificationService: AuthentificationService,
  ) { }

  getPageOfUsers(pageNumber: string, pageSize: string, searchExpression: string, sortName: string, sortOrder: string) {
    this.params = {
      'pageNumber': pageNumber,
      'pageSize': pageSize
    }

    if (sortName && sortOrder) {
      this.params['orderBy'] = `${sortName},${sortOrder}`;
    }

    if (searchExpression) {
      this.params['searchExpression'] = searchExpression;
    }
    var requestHeader = this.authentificationService.getAuthorizationHeader();
    return this.http.get<any>(`${this.baseUrl}get-users/`, { params: this.params, headers: requestHeader })
  }
}
