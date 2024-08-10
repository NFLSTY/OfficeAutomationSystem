namespace OfficeAutomationSystem
{
    public class Activity
    {
        public string? ActivityName { get; set; }
        private List<Meeting> Meetings { get; set; } = new List<Meeting>();

        public void AddMeeting(Meeting meeting)
        {
            Meetings.Add(meeting);
            Console.WriteLine("Meeting added successfully!");
        }

        public void DisplayMeetings()
        {
            foreach (Meeting meeting in Meetings)
            {
                meeting.DisplayMeeting();
            }
        }

        public void AddMeeting()
        {
            Meeting meeting = Meeting.CreateMeeting();
            AddMeeting(meeting);
        }
    }
}
