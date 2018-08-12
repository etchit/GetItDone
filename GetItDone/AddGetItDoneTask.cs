using Foundation;
using System;
using System.IO;
using UIKit;

namespace GetItDone
{
    public partial class AddGetItDoneTask : UIViewController
    {
        
        private string pathToDB;

        public AddGetItDoneTask (IntPtr handle) : base (handle)
        {
            // set the path for the db file
            var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDB = Path.Combine(docFolder, "GetItDoneDB.db");
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            // hide navigation bar to make view controller look like an alertview
            NavigationController.NavigationBarHidden = true;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            cancelBtn.TouchUpInside += CancelBtn_TouchUpInside;
        }

        //When user presses button to "Add" task to their list, add details to TaskList and save into db
        partial void AddButtonWasPressed(UIButton sender)
        {
            using (var connection = new SQLite.SQLiteConnection(pathToDB))
            {
                connection.Insert(new TaskItem()
                {
                    TaskTitle = taskTitleTextField.Text,
                    TaskDescription = taskDescriptionTextView.Text,
                    TaskDueDate = (System.DateTime)dueDatePicker.Date,
                    TaskCompleted = false
                });
            }

            // after data is added to db, unwind to the homescreen
            NavigationController.PopToRootViewController(true);
        }


        void CancelBtn_TouchUpInside(object sender, EventArgs e)
        {
            //When user presses button to "Add" task to their list, add details to TaskList and save into db
            NavigationController.PopToRootViewController(true);
        }

    }
}