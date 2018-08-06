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
    [Register ("AddItemAlertView")]
    partial class AddItemAlertView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CancelBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView containerView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker DueDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TaskDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TaskTitle { get; set; }

        [Action ("AddItemBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddItemBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("CancelBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CancelBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddButton != null) {
                AddButton.Dispose ();
                AddButton = null;
            }

            if (CancelBtn != null) {
                CancelBtn.Dispose ();
                CancelBtn = null;
            }

            if (containerView != null) {
                containerView.Dispose ();
                containerView = null;
            }

            if (DueDate != null) {
                DueDate.Dispose ();
                DueDate = null;
            }

            if (TaskDescription != null) {
                TaskDescription.Dispose ();
                TaskDescription = null;
            }

            if (TaskTitle != null) {
                TaskTitle.Dispose ();
                TaskTitle = null;
            }
        }
    }
}