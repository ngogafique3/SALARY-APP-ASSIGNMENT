using System;

namespace Salary_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double grossSalary;
            double rate;
            int hours;
            Calcurate emp = new Calcurate();
            Console.WriteLine("Enter Employee id");
            emp.EmployeeId= Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter Employee Name");
            emp.EmployeeName= Console.ReadLine();
           Console.WriteLine("Enter Employee Position");
            emp.EmployeePosition= Console.ReadLine();
           Console.WriteLine("Enter Employee Gender");
            emp.EmployeeGender= Console.ReadLine();
            Console.WriteLine("Enter Employee Gross Salary");
            grossSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The monthly salary of {emp.EmployeeName} with id {emp.EmployeeId} on {emp.EmployeePosition} Position is {emp.CalculateMonthlySalary(grossSalary)} ");
            Console.WriteLine($"The one time salary of {emp.EmployeeName} with id {emp.EmployeeId} on {emp.EmployeePosition} Position is {emp.CalculateOneTimeSalary(grossSalary)} ");
            Console.WriteLine("Enter Employee Rate");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Employee Working Hours");
            hours = Convert.ToInt32(Console.ReadLine());
            if (rate != 0 && hours != 0)
            {
                Console.WriteLine($"The one time salary of {emp.EmployeeName} with id {emp.EmployeeId} on {emp.EmployeePosition} Position is {emp.CalculateHourlySalary(rate,hours)} ");
            }
            else
            {
                Console.WriteLine("The one time salary of {emp.EmployeeName} with id {emp.EmployeeId} on {emp.EmployeePosition} Position is 0 ");
            }

        }
    }
}