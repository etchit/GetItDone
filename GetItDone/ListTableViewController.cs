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
            // format the data to show only the day, not time
            cell.DetailTextLabel.Text = data.TaskDueDate.ToShortDateString();


            if(data.TaskCompleted == true){
                cell.Accessory = UITableViewCellAccessory.Checkmark;
                cell.TintColor = UIColor.FromRGB(253, 81, 201);
                DetailViewController.didChangeChecked = true;
            }
            else {
                cell.Accessory = UITableViewCellAccessory.None;
                DetailViewController.didChangeChecked = false;
                data.TaskCompleted = false;
            } 

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

       



  
        // function to swipe right to delete list items.
        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
        {
            switch (editingStyle)
            {
                case UITableViewCellEditingStyle.Delete:
                    // removes the item from the taskList (but does not remote from SQLdb)
                    taskItems.RemoveAt(indexPath.Row);
                    // removes row from tableview
                    tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);

                    // get the ID of the cell that needs to be deleted from the db
                    var id = taskItems[indexPath.Row].ID+1;

                    Console.WriteLine(id);
                    removeTaskfromDB(id);

                    break;
                case UITableViewCellEditingStyle.None:
                    Console.WriteLine("CommitEditingStyle:None called");
                    break;
            }
        }

        // function to remove task item from database when it is removed from list.
        public void removeTaskfromDB(int ID){

            using (var connection = new SQLite.SQLiteConnection(pathToDB))
            {
                // remove item from database and refresh tableview.
                connection.Delete<TaskItem>(primaryKey: ID); 

           
                 TableView.ReloadData();
                Console.WriteLine("Successfully removed item from GetItDone List!");
            }
        }

        public override UISwipeActionsConfiguration GetLeadingSwipeActionsConfiguration(UITableView tableView, NSIndexPath indexPath)
        {

            var markTaskAsCompleteAction = MarkTaskAsCompleteAction(tableView, indexPath);
            var leadingSwipe = UISwipeActionsConfiguration.FromActions(new UIContextualAction[] { markTaskAsCompleteAction});
            leadingSwipe.PerformsFirstActionWithFullSwipe = true;
            return leadingSwipe;
        }

        public UIContextualAction MarkTaskAsCompleteAction(UITableView tableView, NSIndexPath indexPath)
        {
            var action = UIContextualAction.FromContextualActionStyle(UIContextualActionStyle.Normal,
                                                                      "Completed",
                                                                      (FlagAction, view, success) => 
            {
                var cell = tableView.CellAt(indexPath);
                if (cell.Accessory == UITableViewCellAccessory.Checkmark)
                {
                    Console.WriteLine("Oh no, you didnt GotItDone!");
                    cell.Accessory = UITableViewCellAccessory.None;
                    DetailViewController.didChangeChecked = false;
                }
                else {
                    Console.WriteLine("Congratulations, you have GotItDone!");
                    cell.Accessory = UITableViewCellAccessory.Checkmark;
                    cell.TintColor = UIColor.FromRGB(253, 81, 201);
                    DetailViewController.didChangeChecked = true;
                }
             });

            action.Image = UIImage.FromFile("GetItDone.png");
            action.BackgroundColor = UIColor.FromRGB(253, 81, 201);
            return action;
        }




    }
}