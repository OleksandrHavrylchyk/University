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
