using Foundation;
using System;
using UIKit;

namespace GetItDone
{
    public partial class ListTableViewController : UITableViewController
    {
        public ListTableViewController (IntPtr handle) : base (handle)
        {
        }

        partial void AddListItemWasPressed(UIBarButtonItem sender)
        {

            Console.WriteLine("Button Was Pressed");

            UIAlertView alert = new UIAlertView()
            {
                Title = "alert title",
                Message = "this is a simple alert"
            };
            alert.AddButton("OK");
            alert.Show();

            //throw new NotImplementedException();
        }
    }
}