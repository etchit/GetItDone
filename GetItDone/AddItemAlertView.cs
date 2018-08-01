
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

        private UIVisualEffectView effectView = new UIVisualEffectView(UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark));

        public override void ViewDidLoad()
        {
           // setupUI();
        }


        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            this.View.BackgroundColor = UIColor.FromRGB(253, 81, 201);
            UIView popupBox = new UIView(new CGRect(0, 0, (UIScreen.MainScreen.Bounds.Width - 40),(UIScreen.MainScreen.Bounds.Height - 280)));
            popupBox.Center = View.Center;
            popupBox.BackgroundColor = UIColor.White;
            popupBox.Layer.CornerRadius = 5;

        
            View.AddSubview(popupBox);
        }

        private void setupUI(){

            // Get the parent view's layout
            var margins = View.LayoutMarginsGuide;

           

           

            //popupBox.BackgroundColor = UIColor.White;

            ////// Pin the leading edge of the view to the margin
            //NSLayoutConstraint.Create(popupBox, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.LeadingMargin, 1.0f, 0.0f).Active = true;
           
            ////// Pin the trailing edge of the view to the margin
            //NSLayoutConstraint.Create(popupBox, NSLayoutAttribute.Trailing, NSLayoutRelation.Equal, View, NSLayoutAttribute.TrailingMargin, 1.0f, 0.0f).Active = true;
           
            ////// Give the view a 1:2 aspect ratio
            //NSLayoutConstraint.Create(popupBox, NSLayoutAttribute.Height, NSLayoutRelation.Equal, popupBox, NSLayoutAttribute.Width, 2.0f, 0.0f).Active = true;

        }
    }
}