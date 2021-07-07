using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Attendance
    {
        public Course Course { get; set; }
        [Key]
        [Column(Order= 1)]
        public int CourseID { set; get; }
        public ApplicationUser attendee { set; get; }
        [Key]
        [Column(Order =2)]
        public string AttendeeId { set; get; }
    }
}