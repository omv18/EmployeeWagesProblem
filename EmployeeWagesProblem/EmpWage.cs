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
        const int PRESENT = 0, WAGES_PER_HR = 20, FULL_DAY_HR = 8, HALF_DAY_HR = 4, FULL_DAY = 0, HALF_DAY = 1, ABSENT = 2;
        int salary = 0, workinDay = 20, monthlyWage = 0,totalHours=0;
        int sum;
        Random random = new Random();
        public int Attandence()
        {
            int check = random.Next(0, 2);
            return check;
        }
        public int DayCheck()
        {
            int check = random.Next(0, 3);
            return check;
        }

        public void EmpWages()
        {
            while ((workinDay > 0) && (totalHours <= 100))
            {
                int day = DayCheck();
                switch (day)
                {
                    case FULL_DAY:
                        salary = FULL_DAY_HR * WAGES_PER_HR;
                        monthlyWage += salary;
                        totalHours += FULL_DAY_HR;
                        break;
                    case HALF_DAY:
                        salary = HALF_DAY_HR * WAGES_PER_HR;
                        totalHours += HALF_DAY_HR;
                        break;
                    case ABSENT:
                        break;
                }
                workinDay--;
            }
            Console.WriteLine("Employee monthly salary is : " +monthlyWage);
        }
    }
}
