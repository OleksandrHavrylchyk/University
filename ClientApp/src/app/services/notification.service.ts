import { Injectable } from '@angular/core';
import { NzNotificationService } from 'ng-zorro-antd/notification';


@Injectable({
  providedIn: 'root'
})

export class NotificationService {

  constructor(
    private notification: NzNotificationService,
  ) { }

  createNotification(secondDuration: number, message: string, notificationType: string, titleMessage: string): void {
    this.notification.config({
      nzPlacement: 'bottomRight'
    });
    this.notification.create(
      notificationType,
      titleMessage,
      message,
      { nzDuration: secondDuration * 1000 },
    );
  }
}
