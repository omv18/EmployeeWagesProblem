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
        const int PRESENT = 0,WAGES_PER_HR = 20, FULL_DAY = 8;
        int salary = 0;
        Random random = new Random();
        public int Attandence()
        {
            int check = random.Next(0, 2);
            return check;
        }

        public void EmpWages()
        {
            int check = Attandence();
            if(check == PRESENT)
            {
                salary = FULL_DAY * WAGES_PER_HR;
            }
            Console.WriteLine("Employee salary is : " +salary);
        }

    }
}
