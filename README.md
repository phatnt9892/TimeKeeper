# TimeKeeper

## Project Overview
TimeKeeper is an employee time tracking application that allows employees to clock in and clock out, providing an efficient way to track work hours. The application also allows managers to review logs and approve or reject time entries. It's a simple console-based solution built using C# and is designed for organizations that need a lightweight system for employee timekeeping without complex payroll integration.

**Enhancements:**
Future enhancements could include SMS notifications to remind employees about logging hours, and a monthly reporting feature to generate detailed work reports for employees and managers.

---

## Team Members
- Phat Thanh Nguyen (A00304974)
- Mary Eguzoraku (A00283502)
- Godwin Adewale (A00287687)

---

## Features

- **Feature 1**: Add Employee.
  - **Primary**: Phat Thanh Nguyen
  - **Secondary**: Mary Eguzoraku

- **Feature 2**: Remove Employee.
  - **Primary**: Phat Thanh Nguyen
  - **Secondary**: Mary Eguzoraku

- **Feature 3**: List Employees.
  - **Primary**: Phat Thanh Nguyen
  - **Secondary**: Mary Eguzoraku

- **Feature 4**: Clock-In.
  - **Primary**: Phat Thanh Nguyen

- **Feature 5**: Clock-Out.
  - **Primary**: Phat Thanh Nguyen

- **Feature 6**: Review Logs.
  - **Primary**: Phat Thanh Nguyen

---

## Application Flow

1. **Step 1**: The manager adds an employee by providing their name. The employee is then added to the system and can begin clocking in and out.
2. **Step 2**: The manager selects an employee by name and removes them from the system. This action deletes the employee’s record, including all associated work logs.
3. **Step 3**: The manager can view a list of all employees currently in the system. This helps the manager to quickly verify who is in the system.
4. **Step 4**: An employee enters their name, adds a comment, and their clock-in time is recorded. The status is automatically set to "Not Approved".
5. **Step 5**: The employee enters their name again to clock out and logs the end time of their shift. The log is saved for the manager’s review.
6. **Step 6**: The manager views all employee logs, selects each log, and can approve or reject time entries using simple "y" (yes) or "n" (no) commands.

---

## Task Board (Agile Progress Tracker)

### Backlog (Not Started)
- Create base structure of the application (Godwin)
- Research future enhancements (Mary)
- Add comments to code (Mary)

### In Progress (Currently Being Worked On)
- Refactor code for better performance (Godwin)

### In Review
- Implement Review Logs feature (Phat, being reviewed by Godwin)
- Implement Clock-In feature (Phat, being reviewed by Godwin)
- Implement Clock-Out feature (Phat, being reviewed by Godwin)
- Task board setup (Godwin, being reviewed by Phat)

### Completed
- Initial project setup in Visual Studio (Phat)
- Implement Add Employee feature (Phat, reviewed by Mary)
- Implement Remove Employee feature (Phat, reviewed by Mary)
- Implement List Employees feature (Phat, reviewed by Mary)
- Create task board (Godwin)
- Research Agile task tracking strategies (Godwin)
- Console user interface mockup (Mary)

---

## Console User Interfaces

### Main Menu

```text
+--------------------------------+
| ---------------------------     |
|         Time Keeper             |
| ---------------------------     |
| 1. Add Employee                 |
| 2. Remove Employee              |
| 3. List Employees               |
| 4. Clock-In                     |
| 5. Clock-Out                    |
| 6. Review Logs                  |
| 7. Exit and Save                |
| Select an option (1-7):         |
+--------------------------------+
```

### Clock-In Screen

```text
+---------------------------------------------+
| Enter your name: Phat                        |
| Enter a comment: Check-in                    |
| Clock-In recorded. Status: Not Approved.     |
+---------------------------------------------+
```

### Review Logs Screen

```text
+---------------------------------------------------------------------------------------------------------------+
| Enter employee name: Phat                                                                                      |
|                                                                                                                |
| Reviewing logs for Phat:                                                                                       |
| Start: 10/13/2024 3:17:28 AM, End: 10/13/2024 3:22:56 AM, Comment: Check-out, Current Status: Not Approved     |    
| Approve this log? (y for Approved, n for Not Approved): y                                                      |
| Log status updated to: Approved                                                                                |
+---------------------------------------------------------------------------------------------------------------+
```

---

## Sources (Prompts Used with ChatGPT)

1. "Help me design a C# console application for time tracking."
2. "How can I create an approval system for time logs in C#?"
3. "What is a good way to structure an Agile task board for my team project?"
4. "Provide a simple code example for a clock-in and clock-out feature in a C# console application."
