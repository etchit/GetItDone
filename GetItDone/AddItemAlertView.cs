
using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace GetItDone
{
    public partial class AddItemAlertView : UIViewController
    {

        public AddItemAlertView(IntPtr handle) : base(handle)
        {
        }

        private UIVisualEffectView effectView = new UIVisualEffectView(UIBlurEffect.FromStyle(UIBlurEffectStyle.Light));

        public override void ViewDidLoad()
        {
           // setupUI();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            ModalInPopover = true;
        }


        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            // Set background colour
            //this.View.BackgroundColor = UIColor.FromRGB(253, 81, 201);
            this.View.BackgroundColor = UIColor.LightGray.ColorWithAlpha(0.4f);

            // Create container view to house add list item elements.
            UIView popupBox = new UIView(new CGRect(0, 0, (UIScreen.MainScreen.Bounds.Width - 40),(UIScreen.MainScreen.Bounds.Height - 280)));
            popupBox.Center = View.Center;
            popupBox.BackgroundColor = UIColor.White;
            popupBox.Layer.CornerRadius = 5;
            View.AddSubview(popupBox);

            // Create UIView for title label
            UIView titleLabelView = new UIView(new CGRect(0, 0, popupBox.Bounds.Width, 60));
            titleLabelView.Frame.Top.Equals(popupBox.Frame.Top);
            titleLabelView.BackgroundColor = UIColor.FromRGB(253, 81, 201);
            popupBox.AddSubview(titleLabelView);

            UILabel titleLabel = new UILabel();
            titleLabel.Center.Equals(titleLabelView.Center);
            titleLabel.Text = "Add Item to List";
            titleLabel.TextColor = UIColor.Black;
            titleLabelView.AddSubview(titleLabel);
        }
    }
}