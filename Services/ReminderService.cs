using Hangfire;
using NLog;
using System;

namespace University.Services
{
    public class ReminderService
    {
        public void ScheduleRemindEmails(CourseSubscribersEntity courseSubscribersEntity, DateTime studyDate)
        {
            if (DateTime.Compare(DateTime.Now, studyDate.AddDays(-30)) <= 0)
            {
                BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(courseSubscribersEntity.User.Email, "Reminder",
                    $"Dear {courseSubscribersEntity.User.UserName}, we inform you that the course '{courseSubscribersEntity.Course.CourseName}' will start in 30 days," +
                    $" {courseSubscribersEntity.StudyDate}"), studyDate.AddDays(-30));
            }

            if (DateTime.Compare(DateTime.Now, studyDate.AddDays(-7)) <= 0)
            {
                BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(courseSubscribersEntity.User.Email, "Reminder",
                    $"Dear {courseSubscribersEntity.User.UserName}, we inform you that the course '{courseSubscribersEntity.Course.CourseName}' will start in 7 days," +
                    $" {courseSubscribersEntity.StudyDate}"), studyDate.AddDays(-7));
            }

            if (DateTime.Compare(DateTime.Now, (studyDate.AddDays(-1) + new TimeSpan(8, 0, 0))) <= 0)
            {
                BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(courseSubscribersEntity.User.Email, "Reminder",
                    $"Dear {courseSubscribersEntity.User.UserName}, we inform you that the course '{courseSubscribersEntity.Course.CourseName}' will start in the day," +
                    $" {courseSubscribersEntity.StudyDate}"), studyDate.AddDays(-1).Date + new TimeSpan(8, 0, 0));
            }
        }
    }
}
