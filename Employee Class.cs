public class Employee
{
    public string Name { get; set; }
    public List<WorkLog> WorkLogs { get; set; }

    public Employee(string name)
    {
        Name = name;
        WorkLogs = new List<WorkLog>();
    }
}

public class WorkLog
{
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string Comment { get; set; }
    public bool IsApproved { get; set; }

    public WorkLog(DateTime startTime, string comment)
    {
        StartTime = startTime;
        Comment = comment;
        IsApproved = false; // Default status
    }

    public void ClockOut(string comment)
    {
        EndTime = DateTime.Now;
        Comment = comment;
    }
}