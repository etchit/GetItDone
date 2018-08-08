// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GetItDone
{
    [Register ("DetailViewController")]
    partial class DetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel dueDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch taskCompleted { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView taskDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel taskTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dueDate != null) {
                dueDate.Dispose ();
                dueDate = null;
            }

            if (taskCompleted != null) {
                taskCompleted.Dispose ();
                taskCompleted = null;
            }

            if (taskDescription != null) {
                taskDescription.Dispose ();
                taskDescription = null;
            }

            if (taskTitle != null) {
                taskTitle.Dispose ();
                taskTitle = null;
            }
        }
    }
}