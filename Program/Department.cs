namespace OfficeAutomationSystem
{
    public class Department
    {
        public string? DepartmentName { get; set; }
        private List<Employee> Employees { get; set; } = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            Console.WriteLine("Employee added successfully!");
        }

        public void DisplayEmployees()
        {
            foreach (Employee employee in Employees)
            {
                employee.DisplayInfo();
            }
        }

        public void AddEmployee()
        {
            Employee employee = Employee.CreateEmployee();
            AddEmployee(employee);
        }
    }
}
