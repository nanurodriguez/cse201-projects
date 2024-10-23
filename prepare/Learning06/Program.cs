using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Orange", 5);

        Circle circle1 = new Circle("Red", 1.5);

        Rectangle rectangle1 = new Rectangle("Blue", 2, 5);



        //DisplayAreaShapeInfo(square1);
        // DisplayAreaShapeInfo(rectangle1);
        //DisplayAreaShapeInfo(circle1);

        List<Shapes> shapess = new List<Shapes>();
        shapess.Add(square1);
        shapess.Add(circle1);
        shapess.Add(rectangle1);

        foreach (Shapes s in shapess)
        {
            double shapeColorArea = s.GetArea();
            DisplayAreaShapeInfo(s);
        }
    }

    public static void DisplayAreaShapeInfo(Shapes sh)
    {
        double area = sh.GetArea();
        Console.WriteLine($"Shape Color: {sh.GetColor()} -  Area: {area}");
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