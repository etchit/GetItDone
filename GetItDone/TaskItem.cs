using System;
using UIKit;
using SQLite;
using Foundation;

namespace GetItDone
{
    public class TaskItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDueDate { get; set; }
        public bool TaskCompleted { get; set; }

        public TaskItem()
        {
        }

        public TaskItem(string taskTitle, string taskDesription, DateTime taskDuedate, bool taskCompleted)
        { 
            TaskTitle = taskTitle;
            TaskDescription = taskDesription;
            TaskDueDate = taskDuedate;
            TaskCompleted = taskCompleted;
        }
    }
}
