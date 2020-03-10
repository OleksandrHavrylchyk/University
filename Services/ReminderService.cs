using Hangfire;
using System;

namespace University.Services
{
    public class ReminderService
    {
        public void ScheduleRemindEmails(ApplicationUserEntity user, CourseEntity course)
        {

            if (DateTime.Compare(DateTime.Now, course.StartDate.AddDays(-30)) <= 0)
            {
                BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(user.Email, "Reminder",
                    $"Dear {user.UserName}, we inform you that the course '{course.CourseName}' will start in 30 days, {course.StartDate.Date}"), course.StartDate.AddDays(-30));
            }

            if (DateTime.Compare(DateTime.Now, course.StartDate.AddDays(-7)) <= 0)
            {
                BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(user.Email, "Reminder",
                    $"Dear {user.UserName}, we inform you that the course '{course.CourseName}' will start in 7 days, {course.StartDate.Date}"), course.StartDate.AddDays(-7));
            }

            if (DateTime.Compare(DateTime.Now, (course.StartDate.AddDays(-1) + new TimeSpan(8, 0, 0))) <= 0)
            {
                BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(user.Email, "Reminder",
                    $"Dear {user.UserName}, we inform you that the course '{course.CourseName}' will start in the day, {course.StartDate.Date}"), course.StartDate.AddDays(-1) + new TimeSpan(8, 0, 0));
            }
        }
    }
}
