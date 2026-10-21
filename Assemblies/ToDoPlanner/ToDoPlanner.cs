using System;
using System.Collections.Generic;

namespace PlanningApp
{
    class Task
    {
        private static int counter = 1000;   // auto-generates unique IDs
        private int TaskID;
        private string TaskDescription;
        private DateTime TaskStartDate;
        private DateTime TaskEndDate;
        private string TaskPriority;
        private string CompletionStatus;

        public Task(string description, DateTime start, DateTime end, string priority)
        {
            TaskID = ++counter;              // unique value auto-assigned (spec point 8)
            TaskDescription = description;
            TaskStartDate = start;
            TaskEndDate = end;
            TaskPriority = priority;
            CompletionStatus = "Pending";
        }

        public int GetID() { return TaskID; }
        public bool SetStatus(string s) { CompletionStatus = s; return true; }

        public override string ToString()
        {
            return TaskID + " | " + TaskDescription + " | " +
                   TaskStartDate.ToString("dd-MM-yyyy") + " | " +
                   TaskEndDate.ToString("dd-MM-yyyy") + " | " +
                   TaskPriority + " | " + CompletionStatus;
        }
    }

    class ToDoPlanner
    {
        private List<Task> tasks = new List<Task>();

        public bool AddTask(Task obj)
        {
            if (obj == null) return false;
            tasks.Add(obj);
            return true;
        }

        public bool DeleteTask(int intTaskID)
        {
            return tasks.RemoveAll(t => t.GetID() == intTaskID) > 0;
        }

        public bool UpdateTaskStatus(int intTaskID, string strStatus)
        {
            Task t = tasks.Find(x => x.GetID() == intTaskID);
            if (t == null) return false;
            return t.SetStatus(strStatus);   // "Inprogress" or "Completed"
        }

        public Task[] GetTasks()
        {
            return tasks.ToArray();
        }
    }

    class Program
    {
        static void Main()
        {
            ToDoPlanner planner = new ToDoPlanner();

            while (true)
            {
                Console.WriteLine("\n===== TODO PLANNER =====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Update Task Status");
                Console.WriteLine("4. Display All Tasks");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Description : ");
                    string desc = Console.ReadLine();
                    Console.Write("Start Date (dd-MM-yyyy) : ");
                    DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                    Console.Write("End Date (dd-MM-yyyy)   : ");
                    DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                    Console.Write("Priority (high/low)     : ");
                    string priority = Console.ReadLine();

                    Task t = new Task(desc, start, end, priority);
                    bool ok = planner.AddTask(t);
                    Console.WriteLine(ok ? "Task added. ID = " + t.GetID() : "Failed to add task.");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter Task ID to delete : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(planner.DeleteTask(id) ? "Task deleted." : "Task not found.");
                }
                else if (choice == "3")
                {
                    Console.Write("Enter Task ID : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("New Status (Inprogress/Completed) : ");
                    string status = Console.ReadLine();
                    Console.WriteLine(planner.UpdateTaskStatus(id, status) ? "Status updated." : "Task not found.");
                }
                else if (choice == "4")
                {
                    Task[] all = planner.GetTasks();
                    if (all.Length == 0)
                    {
                        Console.WriteLine("No tasks available.");
                    }
                    else
                    {
                        Console.WriteLine("ID | Description | Start | End | Priority | Status");
                        foreach (Task t in all)
                            Console.WriteLine(t);
                    }
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Thank you!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
        }
    }
}
































// ToDo Planner

// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

//  cd /d D:\Assemblies\ToDoPlanner


//   notepad ToDoPlanner.cs


//   csc ToDoPlanner.cs

//   ToDoPlanner






//   Program: ToDoPlanner.cs

//   using System;
//   using System.Collections.Generic;

//   namespace PlanningApp
//   {
//       class Task
//       {
//           private static int counter = 1000;   // auto-generates unique IDs
//           private int TaskID;
//           private string TaskDescription;
//           private DateTime TaskStartDate;
//           private DateTime TaskEndDate;
//           private string TaskPriority;
//           private string CompletionStatus;

//           public Task(string description, DateTime start, DateTime end, string priority)
//           {
//               TaskID = ++counter;              // unique value auto-assigned (spec point 8)
//               TaskDescription = description;
//               TaskStartDate = start;
//               TaskEndDate = end;
//               TaskPriority = priority;
//               CompletionStatus = "Pending";
//           }

//           public int GetID() { return TaskID; }
//           public bool SetStatus(string s) { CompletionStatus = s; return true; }

//           public override string ToString()
//           {
//               return TaskID + " | " + TaskDescription + " | " +
//                      TaskStartDate.ToString("dd-MM-yyyy") + " | " +
//                      TaskEndDate.ToString("dd-MM-yyyy") + " | " +
//                      TaskPriority + " | " + CompletionStatus;
//           }
//       }

//       class ToDoPlanner
//       {
//           private List<Task> tasks = new List<Task>();

//           public bool AddTask(Task obj)
//           {
//               if (obj == null) return false;
//               tasks.Add(obj);
//               return true;
//           }

//           public bool DeleteTask(int intTaskID)
//           {
//               return tasks.RemoveAll(t => t.GetID() == intTaskID) > 0;
//           }

//           public bool UpdateTaskStatus(int intTaskID, string strStatus)
//           {
//               Task t = tasks.Find(x => x.GetID() == intTaskID);
//               if (t == null) return false;
//               return t.SetStatus(strStatus);   // "Inprogress" or "Completed"
//           }

//           public Task[] GetTasks()
//           {
//               return tasks.ToArray();
//           }
//       }

//       class Program
//       {
//           static void Main()
//           {
//               ToDoPlanner planner = new ToDoPlanner();

//               while (true)
//               {
//                   Console.WriteLine("\n===== TODO PLANNER =====");
//                   Console.WriteLine("1. Add Task");
//                   Console.WriteLine("2. Delete Task");
//                   Console.WriteLine("3. Update Task Status");
//                   Console.WriteLine("4. Display All Tasks");
//                   Console.WriteLine("5. Exit");
//                   Console.Write("Enter your choice: ");
//                   string choice = Console.ReadLine();

//                   if (choice == "1")
//                   {
//                       Console.Write("Description : ");
//                       string desc = Console.ReadLine();
//                       Console.Write("Start Date (dd-MM-yyyy) : ");
//                       DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
//                       Console.Write("End Date (dd-MM-yyyy)   : ");
//                       DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
//                       Console.Write("Priority (high/low)     : ");
//                       string priority = Console.ReadLine();

//                       Task t = new Task(desc, start, end, priority);
//                       bool ok = planner.AddTask(t);
//                       Console.WriteLine(ok ? "Task added. ID = " + t.GetID() : "Failed to add task.");
//                   }
//                   else if (choice == "2")
//                   {
//                       Console.Write("Enter Task ID to delete : ");
//                       int id = int.Parse(Console.ReadLine());
//                       Console.WriteLine(planner.DeleteTask(id) ? "Task deleted." : "Task not found.");
//                   }
//                   else if (choice == "3")
//                   {
//                       Console.Write("Enter Task ID : ");
//                       int id = int.Parse(Console.ReadLine());
//                       Console.Write("New Status (Inprogress/Completed) : ");
//                       string status = Console.ReadLine();
//                       Console.WriteLine(planner.UpdateTaskStatus(id, status) ? "Status updated." : "Task not found.");
//                   }
//                   else if (choice == "4")
//                   {
//                       Task[] all = planner.GetTasks();
//                       if (all.Length == 0)
//                       {
//                           Console.WriteLine("No tasks available.");
//                       }
//                       else
//                       {
//                           Console.WriteLine("ID | Description | Start | End | Priority | Status");
//                           foreach (Task t in all)
//                               Console.WriteLine(t);
//                       }
//                   }
//                   else if (choice == "5")
//                   {
//                       Console.WriteLine("Thank you!");
//                       return;
//                   }
//                   else
//                   {
//                       Console.WriteLine("Invalid choice!");
//                   }
//               }
//           }
//       }
//   }