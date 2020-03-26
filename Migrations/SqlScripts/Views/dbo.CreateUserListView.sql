CREATE VIEW DashboardUserList_View
	AS SELECT AspNetUsers.Id,
	AspNetUsers.Name,
	AspNetUsers.LastName,
	AspNetUsers.Age,
	AspNetUsers.Email,
	AspNetUsers.RegisteredDate,
	CourseSubscribers.StudyDate
	FROM AspNetUsers
	LEFT JOIN CourseSubscribers
	ON AspNetUsers.Id = CourseSubscribers.UserId