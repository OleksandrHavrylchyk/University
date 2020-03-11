import { Component, OnInit } from '@angular/core';

import { UserListService } from '../../services/user-list.service';
import { UserList } from '../../interfaces/userListInterfaces';


@Component({
  selector: 'admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})

export class AdminDashboardComponent implements OnInit {

  pageOfUsers: UserList;
  totalUsers: string;
  pageSize: string = "5";
  pageNumber: string = "1";

  constructor(
    private userListService: UserListService,
  ) { }

  getPageOfUsers() {
    this.userListService.getPageOfUsers(this.pageNumber, this.pageSize) 
      .subscribe(
        requestData => {
          this.totalUsers = requestData.pagesModel.totalUsers;
          this.pageOfUsers = requestData.users;
        },
        error => {
          console.log(error);
        });
  }

  setPageSize(pageSize: string) {
    this.pageSize = pageSize;
    this.pageNumber = "1";
    this.getPageOfUsers();
  }

  setNumberPage(pageNumber: string) {
    this.pageNumber = pageNumber;
    this.getPageOfUsers();
  }

  ngOnInit() {
    this.getPageOfUsers();
  }
}
