using Hangfire;
using NLog;
using System;

namespace University.Services
{
    public class ReminderService
    {
        private static Logger logger;

        public ReminderService()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
        public void ScheduleRemindEmails(ApplicationUserEntity user, CourseSubscribersEntity courseSubscribers)
        {
            try
            {
                if (DateTime.Compare(DateTime.Now, courseSubscribers.StudyDate.AddDays(-30)) <= 0)
                {
                    BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(user.Email, "Reminder",
                        $"Dear {user.UserName}, we inform you that the course '{courseSubscribers.Course.CourseName}' will start in 30 days, {courseSubscribers.StudyDate.Date}"), courseSubscribers.StudyDate.AddDays(-30));
                }

                if (DateTime.Compare(DateTime.Now, courseSubscribers.StudyDate.AddDays(-7)) <= 0)
                {
                    BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(user.Email, "Reminder",
                        $"Dear {user.UserName}, we inform you that the course '{courseSubscribers.Course.CourseName}' will start in 7 days, {courseSubscribers.StudyDate.Date}"), courseSubscribers.StudyDate.AddDays(-7));
                }

                if (DateTime.Compare(DateTime.Now, (courseSubscribers.StudyDate.AddDays(-1) + new TimeSpan(8, 0, 0))) <= 0)
                {
                    BackgroundJob.Schedule<EmailSenderService>(service => service.SendEmailAsync(user.Email, "Reminder",
                        $"Dear {user.UserName}, we inform you that the course '{courseSubscribers.Course.CourseName}' will start in the day, {courseSubscribers.StudyDate.Date}"), courseSubscribers.StudyDate.AddDays(-1).Date + new TimeSpan(8, 0, 0));
                }
            }
            catch (Exception exception)
            {
                logger.Error(exception);
                throw;
            }
        }
    }
}
