using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
using SQLite;
using System.IO;

namespace GetItDone
{
    public partial class ListTableViewController : UITableViewController
    {

        private string pathToDB;

        // create list to hold all the to do items
        private List<TaskItem> taskItems;

        // set cell identifier to match result in Main.Storyboard
        string cellIdentifier = "Task";

        public ListTableViewController(IntPtr handle) : base(handle)
        {
            taskItems = new List<TaskItem>();
        }

        // display the number of rows based on how many items in <List>TaskItems
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return taskItems.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // make cell reusuable
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

            // specifiy the data that will load in the cells
            var data = taskItems[indexPath.Row];
            cell.TextLabel.Text = data.TaskTitle;
            cell.DetailTextLabel.Text = data.TaskDueDate.ToString();

            return cell;
        }


        //call this method the first time the view loads only 
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDB = Path.Combine(docFolder, "GetItDoneDB.db");

            using (var connection = new SQLite.SQLiteConnection(pathToDB))
            {
                // table will only be "created" the first time the view is loaded
               connection.CreateTable<TaskItem>();
            }
       
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            // hide navigation bar to make view controller look like an alertview
            NavigationController.NavigationBarHidden = false;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            taskItems = new List<TaskItem>();

            using (var connection = new SQLite.SQLiteConnection(pathToDB))
            {
                // table will be reloaded each time the view appears
                var query = connection.Table<TaskItem>();

                // add one item in TaskItem list per row
                foreach (TaskItem taskItem in query)
                {
                    taskItems.Add(taskItem);
                    TableView.ReloadData();
                }
            }

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "ShowTaskDetailSegue")
            {
                var navigationController = segue.DestinationViewController as DetailViewController;
                if (navigationController != null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var selectedData = taskItems[rowPath.Row];
                    navigationController.selectedTask = selectedData;
                }
            }
        }

    }
}