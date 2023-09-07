using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_3.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string StudentsName { get; set; }

        public int StudentClass { get; set; }

        public float StudentsObtainMarks { get; set; }
    }
}