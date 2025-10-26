using lettheworld_burn;

public class ScheduleManager
{
    public List<Schedule> Schedules { get; set; }

    public ScheduleManager()
    {
        Schedules = new List<Schedule>();
    }

    public void AddSchedule(Schedule schedule)
    {
        Schedules.Add(schedule);
    }
}