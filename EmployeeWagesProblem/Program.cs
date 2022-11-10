using System;

namespace EmployeeWagesProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWage empWage = new EmpWage();
            empWage.EmpWages("DMart");
            EmpWage empWage1 = new EmpWage();
            empWage1.EmpWages("JIO");
        }
    }
}