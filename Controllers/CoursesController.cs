﻿using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using University.Interfaces;


namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesService coursesService;

        public CoursesController(ICoursesService coursesService)
        {
            this.coursesService = coursesService;
        }

        [HttpGet("new-courses")]
        public async Task<ActionResult> GetNewCoursesAsync()
        {

            var coursesAboutToBegin = await coursesService.GetNewCoursesAsync();

            if (coursesAboutToBegin == null)
            {
                return BadRequest("No new courses");
            }

            return Ok(coursesAboutToBegin);
        }

        [HttpGet("courses")]
        public async Task<ActionResult> GetCoursesAsync()
        {
            var courses = await coursesService.GetCoursesAsync();

            if (courses.Count == 0)
            {
                return BadRequest("No courses");
            }

            return Ok(courses);
        }

        [HttpGet("course/{courseUrl}")]
        public async Task<ActionResult> GetCourseInfoAsync(string courseUrl)
        {
            var course = await coursesService.GetCourseInfoAsync(courseUrl);

            if(course.Count == 0)
            {
                return BadRequest("Course does not exist");
            }

            return Ok(course);
        }
    }
}
