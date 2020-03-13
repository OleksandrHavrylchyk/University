export interface IUserList {
  userList: IUserDto[];
}

export interface IUserDto {
  id: string;
  name: string;
  lastName: string;
  age: number;
  email: string;
}
