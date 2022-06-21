﻿public class Salary
{
    public const int empAbsent = 0;
    public const int empPresent = 1;
    public const int empPartTime = 2;

    public const int empSalary = 20;
    public const int MAX_DAYS = 20;
    public const int MAX_HRS = 100;
    //Console.WriteLine("Welcome to Employee Wage Computation Program");

    public void EmployeeWage()
    {
       

     int empHrs = 0, maxDays = 0, empWrkHrs = 0;

        while (empWrkHrs <= MAX_HRS && maxDays < MAX_DAYS)
        {
            maxDays++;

            Random num = new Random();
            int attendance = num.Next(0, 3);

            switch (attendance)
            {
                case 0:
                    Console.WriteLine("Is Absent");
                    empWrkHrs = 0;
                    break;
                case 1:
                    Console.WriteLine("Is Present");
                    empWrkHrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Is PartTime");
                    empWrkHrs = 4;
                    break;
            }
            empWrkHrs += empHrs;
            Console.WriteLine("Day : " + maxDays + "\n " + "Hours : " + empWrkHrs);


            int empWage = (empWrkHrs * empSalary);

            Console.WriteLine("Per Day salary is :" + empWage);

        }

        int monthlyWage = (empWrkHrs * MAX_DAYS * empSalary);
        Console.WriteLine("The Monthly salary is :" + monthlyWage);
    }
    static void Main(String[] args)
    {
        Salary salary = new Salary();
        salary.EmployeeWage();
    }
}