using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CustomViewModel
    {
        [Required]
        public string Place { set; get; }
        [Required]
        [FutureDate]
        public string Date { set; get; }

        [Required]
        public string Time { set; get; }
    }
}