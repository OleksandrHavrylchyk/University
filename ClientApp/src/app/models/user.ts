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
  name: string;
  lastName: string;
  email: string;
  token: string;
}
