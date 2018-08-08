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
    [Register ("AddGetItDoneTask")]
    partial class AddGetItDoneTask
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton addTaskBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton cancelBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker dueDatePicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView taskDescriptionTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField taskTitleTextField { get; set; }

        [Action ("AddButtonWasPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddButtonWasPressed (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (addTaskBtn != null) {
                addTaskBtn.Dispose ();
                addTaskBtn = null;
            }

            if (cancelBtn != null) {
                cancelBtn.Dispose ();
                cancelBtn = null;
            }

            if (dueDatePicker != null) {
                dueDatePicker.Dispose ();
                dueDatePicker = null;
            }

            if (taskDescriptionTextView != null) {
                taskDescriptionTextView.Dispose ();
                taskDescriptionTextView = null;
            }

            if (taskTitleTextField != null) {
                taskTitleTextField.Dispose ();
                taskTitleTextField = null;
            }
        }
    }
}