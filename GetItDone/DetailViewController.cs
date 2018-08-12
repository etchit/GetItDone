using CoreAnimation;
using Foundation;
using System;
using UIKit;

namespace GetItDone
{
    public partial class DetailViewController : UITableViewController
    {
        public TaskItem selectedTask;

        public DetailViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            TableView.BackgroundColor = UIColor.FromRGB(235, 235, 235);

            taskTitle.Text = selectedTask.TaskTitle;
            taskDescription.Text = selectedTask.TaskDescription;
            dueDate.Text = selectedTask.TaskDueDate.ToString();

            checkCompleted = selectedTask.TaskCompleted;

            if (checkCompleted == true){
                taskCompleted.On = true;
            }
            else {
                taskCompleted.On = false;
            }
        }

    }
}