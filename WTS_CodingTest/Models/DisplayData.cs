using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WTS_CodingTest.Models
{
    public class DisplayData
    {

        [Key]
        public int Employee_ID { get; set; }
        public string Employee_FullName { get; set; }
        public double Employee_Hours_Weekly { get; set; }
        public double Employee_Hours_Monthly { get; set; }

    }
}
