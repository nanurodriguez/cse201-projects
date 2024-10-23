using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square();
        square1.SetSide(2);

        Rectangle rectangle1 = new Rectangle();
        rectangle1.SetWidth(3);

        Circle circle1 = new Circle();
        circle1.SetRadius(1.5);

        List<Shapes> shape = new List<Shapes>();
        shape.Add(square1);
        shape.Add(circle1);
        shape.Add(Rec)
    }
    /* HOMEWORK PRACTICE ASSIGNMENT
    HourlyEmployee employee1 = new HourlyEmployee();
    employee1.SetName("Josh");
    employee1.SetIdNumber("235666");
    employee1.SetPayRate(200);
    employee1.SetHoursWorked(40);

    SalaryEmployee employee2 = new SalaryEmployee();
    employee2.SetName("Pedro");
    employee2.SetIdNumber("235777");
    employee2.SetSalary(30000);

    DisplayEmployeeInfo(employee1);
    DisplayEmployeeInfo(employee2);
    //adding a list of employees to show the pay

    List<Employee> employees = new List<Employee>();
    employees.Add(employee1);
    employees.Add(employee2);

    foreach (Employee emp in employees)
    {
        float pay = emp.GetPay();
    }


public static void DisplayEmployeeInfo(Employee employee)
{
    //float pay = employee.GetSalary(); can't work because it can come up with any employee either salary or hourly
    float pay = employee.GetPay();
    Console.WriteLine($"{employee.GetName()} will be paid ${pay}");
}
*/


}