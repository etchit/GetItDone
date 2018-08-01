
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
            setupUI();
        }

        private void setupUI(){
            
            this.View.BackgroundColor = UIColor.FromRGB(253, 81, 201);
        }
    }
}