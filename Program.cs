namespace TimeKeeper
{
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

    internal class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- TimeKeeper Menu ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. List Employees");
                Console.WriteLine("4. Clock-In");
                Console.WriteLine("5. Clock-Out");
                Console.WriteLine("6. Review Logs");
                Console.WriteLine("7. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        RemoveEmployee();
                        break;
                    case "3":
                        ListEmployees();
                        break;
                    case "4":
                        ClockIn();
                        break;
                    case "5":
                        ClockOut();
                        break;
                    case "6":
                        ReviewLogs();
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        // 1. Add Employee
        static void AddEmployee()
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            employees.Add(new Employee(name));
            Console.WriteLine($"Employee {name} added successfully.");
        }

        // 2. Remove Employee
        static void RemoveEmployee()
        {
            Console.Write("Enter employee name to remove: ");
            string name = Console.ReadLine();
            Employee employee = employees.Find(e => e.Name == name);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine($"Employee {name} removed.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // 3. List Employees
        static void ListEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees available.");
            }
            else
            {
                Console.WriteLine("Employee List:");
                foreach (Employee employee in employees)
                {
                    Console.WriteLine($"- {employee.Name}");
                }
            }
        }

        // 4. Clock-In
        static void ClockIn()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Employee employee = employees.Find(e => e.Name == name);
            if (employee != null)
            {
                Console.Write("Enter a comment: ");
                string comment = Console.ReadLine();
                employee.WorkLogs.Add(new WorkLog(DateTime.Now, comment));
                Console.WriteLine("Clock-In recorded. Status: Not Approved.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // 5. Clock-Out
        static void ClockOut()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Employee employee = employees.Find(e => e.Name == name);
            if (employee != null)
            {
                WorkLog lastLog = employee.WorkLogs.FindLast(wl => wl.EndTime == null);
                if (lastLog != null)
                {
                    Console.Write("Enter a comment: ");
                    string comment = Console.ReadLine();
                    lastLog.ClockOut(comment);
                    Console.WriteLine("Clock-Out recorded.");
                }
                else
                {
                    Console.WriteLine("No active Clock-In found.");
                }
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // 6. Review Logs
        static void ReviewLogs()
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Employee employee = employees.Find(e => e.Name == name);
            if (employee != null)
            {
                if (employee.WorkLogs.Count == 0)
                {
                    Console.WriteLine("No logs found for this employee.");
                    return;
                }

                Console.WriteLine($"\nReviewing logs for {name}:");

                // Loop through each work log and ask the manager to approve or reject
                foreach (var log in employee.WorkLogs)
                {
                    string endTime = log.EndTime.HasValue ? log.EndTime.Value.ToString() : "Still working";
                    // Display current status as "Approved" or "Not Approved"
                    string currentStatus = log.IsApproved ? "Approved" : "Not Approved";
                    Console.WriteLine($"Start: {log.StartTime}, End: {endTime}, Comment: {log.Comment}, Current Status: {currentStatus}");

                    // Ask the manager to approve or reject this log
                    Console.Write("Approve this log? (y for Approved, n for Not Approved): ");
                    string input = Console.ReadLine().ToLower();

                    // Update the status based on input
                    if (input == "y")
                    {
                        log.IsApproved = true;
                        Console.WriteLine("Log status updated to: Approved");
                    }
                    else if (input == "n")
                    {
                        log.IsApproved = false;
                        Console.WriteLine("Log status updated to: Not Approved");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, skipping this log.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
