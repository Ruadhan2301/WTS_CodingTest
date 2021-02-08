using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WTS_CodingTest.Models
{
    public class Employee_Works_Shift
    {
        [Key]
        public int Employee_ID { get; set; }
        public int Shift_ID { get; set; }
    }
}
