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
            string? meetingInput = Console.ReadLine();
            if (string.IsNullOrEmpty(meetingInput))
            {
                throw new ArgumentException("Meeting cannot be null or empty");
            }
            meeting.MeetingName = Console.ReadLine();

            Console.Write("Enter The Date (mm/dd/yy): ");
            string? dateInput = Console.ReadLine();
            if (string.IsNullOrEmpty(dateInput))
            {
                throw new ArgumentException("Date cannot be null or empty");
            }
            meeting.MeetingDate = DateTime.Parse(dateInput);

            Console.Write("Enter The Time (hh:mm): ");
            string? timeInput = Console.ReadLine();
            if (string.IsNullOrEmpty(timeInput))
            {
                throw new ArgumentException("Time cannot be null or empty");
            }
            meeting.MeetingDate = DateTime.Parse(timeInput);

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
