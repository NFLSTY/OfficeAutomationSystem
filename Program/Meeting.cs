namespace OfficeAutomationSystem
{
    public class Meeting
    {
        public string? MeetingName { get; set; }
        public DateTime MeetingDate { get; set; }
        public TimeSpan MeetingTime { get; set; }
        public int RoomNumber { get; set; }

        public static Meeting CreateMeeting()
        {
            Meeting meeting = new Meeting();
            Console.Write("Enter Meeting Name: ");
            meeting.MeetingName = Console.ReadLine();
            Console.Write("Enter The Date (mm/dd/yy): ");
            meeting.MeetingDate = DateTime.Parse(Console.ReadLine()?? ""); //dismiss warning
            Console.Write("Enter The Time (hh:mm): ");
            meeting.MeetingTime = TimeSpan.Parse(Console.ReadLine()?? ""); //dismiss warning
            Console.Write("Enter Room Number: ");
            meeting.RoomNumber = Convert.ToInt32(Console.ReadLine());
            return meeting;
        }

        public void DisplayMeeting()
        {
            Console.WriteLine($"Meeting: {MeetingName}, Date: {MeetingDate:MM/dd/yyyy}, Time: {MeetingTime:hh\\:mm}, Room: {RoomNumber}");
        }
    }
}
