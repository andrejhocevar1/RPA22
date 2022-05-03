﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class Student
    {
        private const string V = "Starost";

        public int StudentId { get; set;}
        [Display(Name ="Ime")]
        [Required(ErrorMessage ="Ime je obvezen podatek")]
        public string StudentName { get; set; }
        [Display(Name ="Starost")]
        [Range(5,50,ErrorMessage ="Med 5 in 50")]
        public int Age { get; set; }
    }
}