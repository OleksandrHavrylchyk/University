import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

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
  searchField: string;

  constructor(
    private userListService: UserListService,
    private activatedRoute: ActivatedRoute,
    private router: Router
  ) { }

  getPageOfUsers() {
    this.userListService.getPageOfUsers(this.pageNumber, this.pageSize, this.searchField) 
      .subscribe(
        requestData => {
          this.totalUsers = requestData.pagesModel.totalUsers;
          this.pageOfUsers = requestData.users;
        },
        error => {
          console.log(error);
        });
  }

  searchByField() {
    if (this.searchField) {
      this.pageNumber = "1";
      this.router.navigate(['admin-dashboard'], { queryParams: { pageNumber: this.pageNumber, pageSize: this.pageSize, search: this.searchField } });
    }
    else {
      this.router.navigate(['admin-dashboard'], { queryParams: { pageNumber: this.pageNumber, pageSize: this.pageSize } });
    }
  }

  changePageSize(pageSize: string) {
    this.pageNumber = "1";
    if (this.searchField) {
      this.router.navigate(['admin-dashboard'], { queryParams: { pageNumber: this.pageNumber, pageSize: pageSize, search: this.searchField } });
    }
    else {
      this.router.navigate(['admin-dashboard'], { queryParams: { pageNumber: this.pageNumber, pageSize: pageSize } });
    }
  }

  changeNumberPage(pageNumber: string) {
    if (this.searchField) {
      this.router.navigate(['admin-dashboard'], { queryParams: { pageNumber: pageNumber, pageSize: this.pageSize, search: this.searchField } });
    }
    else {
      this.router.navigate(['admin-dashboard'], { queryParams: { pageNumber: pageNumber, pageSize: this.pageSize } });
    }
  }

  ngOnInit() {
    this.activatedRoute.queryParams.subscribe(params => {
      if (Object.keys(params).length) {
        this.pageNumber = params['pageNumber'] ? params['pageNumber'] : this.pageNumber;
        this.pageSize = params['pageSize'] ? params['pageSize'] : this.pageSize;
        this.searchField = params['search'] ? params['search'] : this.searchField;
        this.getPageOfUsers();
      }
    })
    this.getPageOfUsers();
  }
}
