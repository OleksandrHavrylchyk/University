import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { UserManageService } from '../../services/user-manage.service';
import { UserListService } from '../../services/user-list.service';
import { IUserList } from '../../interfaces/userListInterfaces';
import { NotificationService } from '../../services/notification.service';
import { CoursesService } from '../../services/courses.service';
import { EditUserDto } from '../../models/user';


@Component({
  selector: 'admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})

export class AdminDashboardComponent implements OnInit {

  pageOfUsers: IUserList;
  currentTab: string = 'users';
  coursesInformation: any;
  editUser: EditUserDto = new EditUserDto();
  totalUsers: string;
  pageSize: string = "10";
  pageNumber: string = "1";
  searchField: string;
  sortName: string;
  sortOrder: string;
  isModalVisible = false;

  mapOfSort: { [key: string]: string | null } = {
    name: null,
    lastName: null,
    age: null,
    email: null,
    registeredDate: null,
    studyDate: null
  };

  constructor(
    private userListService: UserListService,
    private userManageService: UserManageService,
    private activatedRoute: ActivatedRoute,
    private notificationService: NotificationService,
    private coursesService: CoursesService,
    private router: Router
  ) { }

  getPageOfUsers() {
    this.userListService.getPageOfUsers(this.pageNumber, this.pageSize, this.searchField, this.sortName, this.sortOrder)
      .subscribe(
        requestData => {
          this.totalUsers = requestData.pagesModel.totalUsers;
          this.pageOfUsers = requestData.users;
        },
        error => {
          console.log(error);
        });
  }

  getHeightStyle() {
    if (this.currentTab == 'courses') {
      return { height: 'unset'};
    }
    return { height: '115%' };
  }

  changeTab(tabName: string) {
    this.currentTab = tabName;
  }

  getListOfSubscribers(courseData: any) {
    return courseData.courseSubscribers;
  }

  getCoursesInformation() {
    this.coursesService.getAdminDashboardCourses().subscribe(
      requestData => {
        this.coursesInformation = requestData;
      },
      error => {
        console.log(error);
      }
    );
  }

  showModal(userEditData: EditUserDto): void {
    this.editUser = userEditData;
    this.isModalVisible = true;
  }

  handleOk() {
    this.userManageService.putUserData(this.editUser)
      .subscribe(
        requestData => {
          this.notificationService.createNotification(2, 'Saved', 'success', 'Success');
          this.getPageOfUsers();
          this.hideModal();
        },
        error => {
          console.log(error);
        });
  }

  hideModal(): void {
    this.isModalVisible = false;
  }

  sort(sortName: string, sortOrder: string): void {
    this.sortName = sortName;
    this.sortOrder = sortOrder;

    for (const key in this.mapOfSort) {
      this.mapOfSort[key] = key === sortName ? sortOrder : null;
    }
    this.getPageOfUsers();
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
    this.getCoursesInformation();
    this.getPageOfUsers();
  }
}
