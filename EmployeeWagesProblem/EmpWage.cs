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
        int PRESENT = 0;
        Random random = new Random();
        public void Attandence()
        {
            int check = random.Next(0, 2);
            if(check == PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
