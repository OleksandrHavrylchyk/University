export class AuthentificationUser {
  id: string;
  userName: string;
  password: string;
}

export class EditUserDto {
  id: string = "";
  name: string = "";
  lastName: string = "";
  age: number = 0;
  email: string = "";
}

export class FacebookAuthUser {
  userName: string;
  name: string;
  lastName: string;
  email: string;
  token: string;
}

export class RefreshTokenModel {
  token: string;
  refreshToken: string;
}
