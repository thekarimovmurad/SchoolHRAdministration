using HRAdministrationAPI;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        decimal totalSalaries = 0;
        List<IEmployee> employees = new List<IEmployee>();
        SeedData(employees);
        //foreach (IEmployee employee in employees)
        //    totalSalaries += employee.Salary;
        //Console.WriteLine(totalSalaries);
        //Console.WriteLine(employees.Sum(e=>e.Salary));

        Console.ReadKey();

    }
    public static void SeedData(List<IEmployee> employees)
    {
        IEmployee teacher1 = new Teacher
        {
            Id = 1,
            FirstName = "Bobik",
            LastName = "Fisher",
            Salary = 50000
        };
        employees.Add(teacher1);
        IEmployee teacher2 = new Teacher
        {
            Id = 2,
            FirstName = "Jhon",
            LastName = "Chak",
            Salary = 55000
        };
        employees.Add(teacher2);
        IEmployee headOfDepartment = new Teacher
        {
            Id = 3,
            FirstName = "Branda",
            LastName = "Mullnis",
            Salary = 60000
        };
        employees.Add(headOfDepartment);
        IEmployee deputyHeadMaster = new Teacher
        {
            Id = 4,
            FirstName = "Devil",
            LastName = "Jhack",
            Salary = 65000
        };
        employees.Add(deputyHeadMaster);
        IEmployee headMaster = new Teacher
        {
            Id = 5,
            FirstName = "Jony",
            LastName = "Niece",
            Salary = 65000
        };
        employees.Add(headMaster);
    }


}

public class Teacher:EmployeeBase
{
    public override decimal Salary { get => base.Salary + base.Salary * 0.02m; }

}
public class HeadOfDepartment : EmployeeBase
{
    public override decimal Salary { get => base.Salary + base.Salary * 0.03m; }

}
public class DeputyHeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + base.Salary * 0.04m; }

}
public class HeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + base.Salary * 0.05m; }

}
