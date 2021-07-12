using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        private IEnumerable<Course> UpcommingCourses { set; get; }

        public bool ShowAction { set; get; }
    }
}