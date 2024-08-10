namespace OfficeAutomationSystem
{
    public class Employee : Person
    {
        public string? EmployeeID { get; set; }
        public string? Department { get; set; }

        public static Employee CreateEmployee()
        {
            Employee employee = new Employee();
            Console.Write("Enter Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            employee.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee ID: ");
            employee.EmployeeID = Console.ReadLine();
            Console.Write("Enter Department: ");
            employee.Department = Console.ReadLine();
            return employee;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Employee ID: {EmployeeID}, Department: {Department}");
        }
    }
}
