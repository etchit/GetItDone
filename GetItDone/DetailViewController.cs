using CoreAnimation;
using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace GetItDone
{
    public partial class DetailViewController : UITableViewController
    {
        public TaskItem selectedTask;
        public static bool didChangeChecked;

        private string pathToDB;

        public DetailViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            // set background colour
            TableView.BackgroundColor = UIColor.FromRGB(235, 235, 235);

            // set all the textfields based on db values
            taskTitle.Text = selectedTask.TaskTitle;
            taskDescription.Text = selectedTask.TaskDescription;
            dueDate.Text = selectedTask.TaskDueDate.ToString();
            taskCompleted.On = selectedTask.TaskCompleted;

            var checkCompleted = selectedTask.TaskCompleted;

            // check whether or not task is marked as completed
            if (checkCompleted == true || didChangeChecked == true){
                taskCompleted.On = true;
                didChangeChecked = true;

            }
            else {
                taskCompleted.On = false;
                didChangeChecked = false;
            }
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDB = System.IO.Path.Combine(docFolder, "GetItDoneDB.db");
        }

        partial void DidToggleCompleted(UISwitch sender)
        {
            var checkCompleted = selectedTask.TaskCompleted;

            if (checkCompleted == true || didChangeChecked == true)
            {
                taskCompleted.On = true;
                didChangeChecked = true;
                selectedTask.TaskCompleted = true;

            }
            else
            {
                taskCompleted.On = false;
                didChangeChecked = false;
                selectedTask.TaskCompleted = false;
            }
        }
         
    }
}