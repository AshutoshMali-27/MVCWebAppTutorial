using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebAppTutorial.Models
{
    public class ClsDataAnnotation
    {
        [Required (ErrorMessage ="Id is Mendatory")]
        public int EmployeeId { get; set; }
        [Required (ErrorMessage = "Name is Mendatory")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="Name Should be in between 20 and 5")]
        public string EmployeeName { get; set; }

        [Required (ErrorMessage = "Age is Mendatory")]
        public int EmployeeAge { get; set; }

        [Required (ErrorMessage = "Gender is Mendatory")]
        public string EmployeeGender { get; set; }

        [Required(ErrorMessage = "Email is Mendatory")]
        public string EmployeeEmail { get; set; }
    }
}