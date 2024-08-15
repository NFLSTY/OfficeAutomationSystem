namespace OfficeAutomationSystems
{
    public class Task
    {
        public string? TaskName { get; set; }
        public string? AssignedTo { get; set; }
        public string? Details { get; set; }

        public static Task CreateTask()
        {
            Task task = new Task();
            Console.Write("Enter Task Name: ");
            task.TaskName = Console.ReadLine();
            
            Console.Write("Enter Assigned To: ");
            task.AssignedTo = Console.ReadLine();
            
            Console.Write("Enter Details: ");
            task.Details = Console.ReadLine();
            return task;
        }
        
        public void DisplayTask()
        {
            Console.WriteLine($"Task: {TaskName}, Assigned To: {AssignedTo}, Details: {Details}");
        }
    }
}
