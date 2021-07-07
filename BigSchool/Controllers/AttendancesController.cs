using BigSchool.DTOs;
using BigSchool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        /*[HttpPost]
                 public IHttpActionResult Attend(AttendanceDto attendanceDto)
                 {

                     var userId = User.Identity.GetUserId();
                     if (_dbContext.Attendances.Any(a => a.AttendeeId == userID && a.CourseId == attendaneceDto.CourseId))
                         return BadRequest("the Attendence alredy exitsts");
                     var attendane = new Attendance
                     {
                         CourseId = attendanceDto.courseId,
                         AttendanceId = userID
                     };
                     _dbContext.Attendances.Add(Attendance);
                     _dbContext.SaveChanges();
                     return Ok();
             }*/


    }
}

