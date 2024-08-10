using OfficeAutomationSystems;

namespace OfficeAutomationSystem
{
    public class Program
    {
        Department department = new Department();
        Project project = new Project();
        Activity activity = new Activity();

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Name()
        {
            department.DepartmentName = "IT";
            project.ProjectName = "Office Automation System";
            activity.ActivityName = "Implementing OOP Pillars";
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Office Automation System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Add Meeting");
                Console.WriteLine("4. Display Information");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        department.AddEmployee();
                        break;
                    case 2:
                        project.AddTask();
                        break;
                    case 3:
                        activity.AddMeeting();
                        break;
                    case 4:
                        DisplayInformation();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public void DisplayInformation()
        {
            bool displaying = true;
            while (displaying)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Display Information");
                Console.WriteLine("1. Display Employees");
                Console.WriteLine("2. Display Tasks");
                Console.WriteLine("3. Display Meetings");
                Console.WriteLine("4. Back To Menu");
                Console.Write("Select an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        department.DisplayEmployees();
                        break;
                    case 2:
                        project.DisplayTasks();
                        break;
                    case 3:
                        activity.DisplayMeetings();
                        break;
                    case 4:
                        displaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}