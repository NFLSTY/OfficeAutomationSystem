namespace OfficeAutomationSystems
{
    public class Project
    {
        public string? ProjectName { get; set; }  
        private List<Task> Tasks { get; set; } = new List<Task>();

        public void AddTask(Task task)
        {
            Tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        public void DisplayTasks()
        {
            foreach (Task task in Tasks)
            {
                task.DisplayTask();
            }
        }

        public void AddTask()
        {
            Task task = Task.CreateTask();
            AddTask(task);
        }
    }
}
