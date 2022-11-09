using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProblem
{
    internal class EmpWage
    {
        const int PRESENT = 0,WAGES_PER_HR = 20, FULL_DAY_HR = 8, HALF_DAY_HR = 4, FULL_DAY = 0, HALF_DAY = 1 ;
        int salary = 0;
        Random random = new Random();
        public int Attandence()
        {
            int check = random.Next(0, 2);
            return check;
        }
        public int DayCheck()
        {
            int check = random.Next(0, 2);
            return check;
        }

        public void EmpWages()
        {
            int check = Attandence();
            if(check == PRESENT)
            {
                int day = DayCheck();
                if(day == FULL_DAY)
                {
                    salary = FULL_DAY_HR * WAGES_PER_HR;
                }
                else if(day == HALF_DAY)
                {
                    salary = HALF_DAY_HR * WAGES_PER_HR;
                }
            }
            Console.WriteLine("Employee salary is : " +salary);
        }
    }
}
