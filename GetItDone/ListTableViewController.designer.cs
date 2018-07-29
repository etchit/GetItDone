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
    [Register ("ListTableViewController")]
    partial class ListTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem AddListItem { get; set; }

        [Action ("AddListItemWasPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddListItemWasPressed (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddListItem != null) {
                AddListItem.Dispose ();
                AddListItem = null;
            }
        }
    }
}