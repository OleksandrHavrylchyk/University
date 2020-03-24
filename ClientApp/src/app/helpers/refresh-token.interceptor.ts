import { Injectable } from "@angular/core";
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from "@angular/common/http";
import { AuthentificationService } from "../services/authentification.service";
import { Observable } from "rxjs";
import { JwtHelperService } from "@auth0/angular-jwt";

@Injectable()
export class RefreshTokenInterceptor implements HttpInterceptor {
  isTokenRefreshed = false;
  private jwtHelper = new JwtHelperService();

  constructor(public authenticationService: AuthentificationService) { }

  intercept(
    request: HttpRequest<any>,
    next: HttpHandler): Observable<HttpEvent<any>> {

    if (!(request.url.search("api/") == -1) && !this.isTokenRefreshed) {
      var token = localStorage.getItem('token');
      var refreshToken = localStorage.getItem('refreshToken');

      if (token && new Date().getTime() > (this.jwtHelper.getTokenExpirationDate(token).getTime() - 60000)) {
        this.isTokenRefreshed = true;
        this.authenticationService.refreshToken({ token, refreshToken }).subscribe(response => {
          localStorage.setItem('token', response.token);
          localStorage.setItem('refreshToken', response.refreshToken);
          this.isTokenRefreshed = false;
        },
          error => {
            console.log(error);
            this.authenticationService.logout();
          });

        return next.handle(request).pipe();
      }

      else {
        return next.handle(request).pipe();
      }

    }

    return next.handle(request).pipe();
  }
}
