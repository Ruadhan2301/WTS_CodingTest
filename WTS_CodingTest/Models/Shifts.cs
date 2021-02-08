using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WTS_CodingTest.Models
{
    public class Shifts
    {
        [Key]
        public int Shift_ID { get; set; }
        public DateTime Shift_Start { get; set; }
        public DateTime Shift_End { get; set; }
        public string Shift_Name { get; set; }
    }
}
