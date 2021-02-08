using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WTS_CodingTest.Models;

namespace WTS_CodingTest.Managers
{
    public class ShiftManager : IShiftManager
    {
        private WTSContext _context;

        public ShiftManager(WTSContext context)
        {
            _context = context;
        }
               

        /// <summary>
        /// Constructs the full display dataset for each employee
        /// </summary>
        /// <returns></returns>
        public List<DisplayData> GetDisplayData()
        {
            List<DisplayData> output = new List<DisplayData>();
            List<Employee> employees = _context.Employee.ToList(); // retrieve the employee data from the database

            foreach (Employee employee in employees)
            {
                DisplayData data = BuildDisplayData(employee);
                if (data != null)
                {
                    output.Add(data);
                }
            }

            return output;
        }

        /// <summary>
        /// Constructs the data for display for a given employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        private DisplayData BuildDisplayData(Employee employee)
        {
            DisplayData output = new DisplayData();

            output.Employee_ID = employee.Employee_ID;
            output.Employee_FullName = employee.FirstName + " " + employee.Surname;
            output.Employee_Hours_Weekly = CalculateHours(employee, 1);
            output.Employee_Hours_Monthly = CalculateHours(employee, 4);

            return output;

        }

        /// <summary>
        /// For a given Employee, returns the number of hours they work in a month.
        /// </summary>
        /// <returns></returns>
        private double CalculateHours(Employee employee, int weeks = 1)
        {
            int id = employee.Employee_ID;
            List<Employee_Works_Shift> employeeShifts = _context.Employee_Works_Shift.Where(c => c.Employee_ID == id).ToList();
            List<Shifts> shifts = _context.Shifts.ToList();
            double totalHours = 0;
            
            foreach(Employee_Works_Shift shift in employeeShifts)
            {
                int shiftID = shift.Shift_ID;
                Shifts shiftData = shifts.FirstOrDefault(c => c.Shift_ID == shiftID);
                // Cross-reference the data between the shifts and employee_works_shift tables. 
                //We could feasibly actually merge the data, but this is a much simpler approach.
                if (shiftData != null)
                {
                    double hours = CalculateShiftLength(shiftData);
                    totalHours += hours;
                }
            }
            totalHours *= weeks; 
            // There are four weeks in a month (give or take), so simply multiplying up the values gets us the monthly total.
            // In the absence of full monthly data, this will have to do.

            return totalHours;
        }

        /// <summary>
        /// returns the number of hours in a shift
        /// </summary>
        /// <param name="shift"></param>
        /// <returns></returns>
        private double CalculateShiftLength(Shifts shift)
        {

            DateTime start = shift.Shift_Start;
            DateTime end = shift.Shift_End;
            TimeSpan span = end - start;
            double hours = span.TotalHours;
            // Using span allows the shifts to be irrespective of days, allowing theoretical 24h+ Shifts, or nightshifts that start in the evening and finish the next day.
            return hours;
            
        }



    }
}
