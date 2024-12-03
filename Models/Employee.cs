using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeProject_2.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RegularExpression("^[A-B]{3,3}[0-9]{3,3}",ErrorMessage ="Empty value is not allowed")]
        public string EmployeeId {  get; set; }
        [Required(ErrorMessage ="Empty Name is not allowed")]
        [MinLength(4,ErrorMessage ="Name should be atlest 4 chars")]
        [MaxLength(50,ErrorMessage ="Name should be atlest more than 4")]
        public string EmployeeName {  get; set; }

        [Required(ErrorMessage ="Empty Descrption is not allowed")]
        [MaxLength(500,ErrorMessage ="Description should be less than 500")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Empty Descrption is not allowed")]
        [Range(1,50000,ErrorMessage ="Salary starts from 1 to 50000")]
        public int Salary {  get; set; }
    }
}