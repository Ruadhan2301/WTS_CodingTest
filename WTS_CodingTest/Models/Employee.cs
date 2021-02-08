using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WTS_CodingTest.Models
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
