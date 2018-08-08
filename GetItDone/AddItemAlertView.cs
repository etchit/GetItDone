
using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace GetItDone
{
    public partial class AddItemAlertView : UIViewController
    {
        partial void CancelBtn_TouchUpInside(UIButton sender)
        {
            Console.WriteLine("User pressed cancel");
        }

        partial void AddItemBtn_TouchUpInside(UIButton sender)
        {
            Console.WriteLine("User pressed add item");
        }




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

        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

                // Set background colour
                this.View.BackgroundColor = UIColor.LightGray.ColorWithAlpha(0.4f);


            View.AddSubview(containerView);
            containerView.Center = View.Center;

         

            CancelBtn.Layer.BorderWidth = 1;
            CancelBtn.Layer.BorderColor = UIColor.LightGray.CGColor;
        }


        //public override void ViewWillLayoutSubviews()
        //{
        //    base.ViewWillLayoutSubviews();

        //    // Set background colour
        //    this.View.BackgroundColor = UIColor.LightGray.ColorWithAlpha(0.4f);

        //    // Create container view to house add list item elements.
        //    UIView popupBox = new UIView(new CGRect(0, 0, (UIScreen.MainScreen.Bounds.Width - 40), (UIScreen.MainScreen.Bounds.Height - 280)));
        //    popupBox.Center = View.Center;
        //    popupBox.BackgroundColor = UIColor.White;
        //    popupBox.Layer.CornerRadius = 5;
        //    View.AddSubview(popupBox);


        //    ////// Create Cancel button
        //    //UIButton cancelBtn = new SizeView(new CGSize(40, 100));
        //    //cancelBtn.BackgroundColor = UIColor.Blue;
        //    //cancelBtn.SetTitle("Cancel", UIControlState.Normal);

        //    ////// Create Add button
        //    //UIButton addBtn = new SizeView(new CGSize(40, 100));
        //    //addBtn.BackgroundColor = UIColor.Blue;
        //    //addBtn.SetTitle("Add", UIControlState.Normal);


        //    //var buttonLayout = new UIStackView()
        //    //{
        //    //    Axis = UILayoutConstraintAxis.Horizontal,
        //    //    Alignment = UIStackViewAlignment.Center,
        //    //    Distribution = UIStackViewDistribution.EqualSpacing,
        //    //    Spacing = 20
        //    //};

        //    //buttonLayout.BackgroundColor = UIColor.Black;

        //    //View.AddSubview(buttonLayout);
        //    //View.AddConstraint(buttonLayout.BottomAnchor.ConstraintEqualTo(popupBox.BottomAnchor));
        //    //View.AddConstraint(buttonLayout.LeftAnchor.ConstraintEqualTo(popupBox.LeftAnchor));
        //    //View.AddConstraint(buttonLayout.RightAnchor.ConstraintEqualTo(popupBox.RightAnchor));
        //    //View.AddConstraint(buttonLayout.HeightAnchor.ConstraintEqualTo(60));

        //    //buttonLayout.AddArrangedSubview(cancelBtn);
        //    //buttonLayout.AddArrangedSubview(addBtn);

        //    // Create UIView for title label
        //    UIView titleLabelView = new UIView(new CGRect(0, 0, popupBox.Bounds.Width, 60));
        //    titleLabelView.Frame.Top.Equals(popupBox.Frame.Top);
        //    titleLabelView.BackgroundColor = UIColor.FromRGB(253, 81, 201);
        //    popupBox.AddSubview(titleLabelView);

        //    ////// Create container view to house add buttons.
        //    //UIView btnView = new UIView(new CGRect(0, (popupBox.Bounds.Height - 60), popupBox.Bounds.Width, 60));
        //    //btnView.Frame.Bottom.Equals(popupBox.Frame.Bottom);
        //    //btnView.BackgroundColor = UIColor.Black;
        //    //popupBox.AddSubview(btnView);

        //    UILabel titleLabel = new UILabel(new CGRect(titleLabelView.Bounds.X, titleLabelView.Bounds.Y, titleLabelView.Bounds.Width, titleLabelView.Bounds.Height));
        //    // titleLabel.Frame.Size.Equals(titleLabelView.Frame.Size);
        //    titleLabel.Text = "Add Item to List";
        //    titleLabel.TextColor = UIColor.White;
        //    titleLabel.TextAlignment = UITextAlignment.Center;
        //    titleLabelView.AddSubview(titleLabel);
        //    titleLabelView.BringSubviewToFront(titleLabel);

        //    //// Create Cancel button
        //    //UIButton cancelBtn = new UIButton(new CGRect(20, ((btnView.Bounds.Height / 2) - 20), (popupBox.Bounds.Width / 3), 40));
        //    //cancelBtn.BackgroundColor = UIColor.Blue;
        //    //cancelBtn.SetTitle("Cancel", UIControlState.Normal);
        //    //btnView.AddSubview(cancelBtn);

        //    UITextField itemTitle = new UITextField(new CGRect((popupBox.Bounds.Width/2 - (popupBox.Bounds.Width - 40) /2), titleLabelView.Bounds.Y + 80, popupBox.Bounds.Width - 40, 30));
        //    itemTitle.Font = UIFont.FromName("Helvetica-Neue", 14.0f);
        //    itemTitle.Placeholder = "Enter item title";
        //    itemTitle.Layer.CornerRadius = 5;
        //    itemTitle.Layer.BorderWidth = 1;
        //    popupBox.AddSubview(itemTitle);
        //    titleLabelView.BringSubviewToFront(itemTitle);


        //    UITextView itemDescription = new UITextView(new CGRect((popupBox.Bounds.Width / 2 - (popupBox.Bounds.Width - 40) / 2), itemTitle.Bounds.Y + 110, popupBox.Bounds.Width - 40, 80));
        //    itemDescription.Text = "Enter item description";
        //    itemTitle.Font = UIFont.FromName("Helvetica-Neue", 14.0f);
        //    itemDescription.Layer.CornerRadius = 5;
        //    itemDescription.Layer.BorderWidth = 1;
        //    popupBox.AddSubview(itemDescription);
        //    titleLabelView.BringSubviewToFront(itemDescription);

        //    // Create Cancel button
        //    cancelBtn.Layer.BorderColor = UIColor.FromRGB(253, 81, 201).CGColor;
        //    cancelBtn.HeightAnchor.ConstraintEqualTo(100);
        //    cancelBtn.WidthAnchor.ConstraintEqualTo(200);
        //    popupBox.AddSubview(cancelBtn);

        //    // Create Add button
        //    UIButton addBtn = new UIButton();
        //    addBtn.BackgroundColor = UIColor.Red;
        //    addBtn.HeightAnchor.ConstraintEqualTo(100);
        //    addBtn.WidthAnchor.ConstraintEqualTo(200);

        //    ////// Create Add button
        //    //UIButton addBtn = new UIButton(new CGRect(280, ((btnView.Bounds.Height / 2) - 20), (popupBox.Bounds.Width / 3), 40));
        //    //addBtn.BackgroundColor = UIColor.Blue;
        //    //addBtn.SetTitle("Add", UIControlState.Normal);
        //    //btnView.AddSubview(addBtn);

        //    UIStackView btnStack = new UIStackView()
        //    {
        //        Axis = UILayoutConstraintAxis.Horizontal,
        //        Alignment = UIStackViewAlignment.Center,
        //        Distribution = UIStackViewDistribution.EqualSpacing,
        //        Spacing = 40
        //    };

        //    btnStack.AddArrangedSubview(cancelBtn);
        //    btnStack.AddArrangedSubview(addBtn);

        //    //Layout for Stack View
        //    btnStack.Center.Equals(View.Center);
        //    btnStack.TranslatesAutoresizingMaskIntoConstraints = false;


        //}


        public void setupStackViews() {

            //Create Container Stackview
            UIStackView containerStackView = new UIStackView()
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Axis = UILayoutConstraintAxis.Horizontal,
                Alignment = UIStackViewAlignment.Fill,
                Distribution = UIStackViewDistribution.EqualSpacing,
                Spacing = 20,
                LayoutMargins = new UIEdgeInsets(150, 20, 150, 20),
                LayoutMarginsRelativeArrangement = true
            };

            View.AddSubview(containerStackView);

            // Nested stacks

            var buttonView = new UIStackView
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Axis = UILayoutConstraintAxis.Horizontal,
                Alignment = UIStackViewAlignment.Fill,
                Distribution = UIStackViewDistribution.FillEqually,
                Spacing = 4
            };

            var nested2 = new UIStackView
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Axis = UILayoutConstraintAxis.Horizontal,
                Alignment = UIStackViewAlignment.Fill,
                Distribution = UIStackViewDistribution.EqualSpacing,
                Spacing = 4
            };

            var nested3 = new UIStackView
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Axis = UILayoutConstraintAxis.Horizontal,
                Alignment = UIStackViewAlignment.Fill,
                Distribution = UIStackViewDistribution.FillProportionally,
                Spacing = 4
            };

            //View 1
            UIView view1 = new UIView();
            view1.BackgroundColor = UIColor.Blue;
            view1.HeightAnchor.ConstraintEqualTo(100);
            view1.WidthAnchor.ConstraintEqualTo(200);


            //View 2
            UIView view2 = new UIView();
            view2.BackgroundColor = UIColor.Blue;
            view2.HeightAnchor.ConstraintEqualTo(100);
            view2.WidthAnchor.ConstraintEqualTo(200);

            //View 3
            UIView view3 = new UIView();
            view3.BackgroundColor = UIColor.Blue;
            view3.HeightAnchor.ConstraintEqualTo(100);
            view3.WidthAnchor.ConstraintEqualTo(200);


            containerStackView.AddArrangedSubview(buttonView);
            containerStackView.AddArrangedSubview(nested2);
            containerStackView.AddArrangedSubview(nested3);
            //stackView.TranslatesAutoresizingMaskIntoConstraints = false;
            //View.AddSubview(stackView);


            //Layout for Stack View
            //stackView.Center.Equals(View.Center);


        }

        public class SizeView : UIButton
        {
            CGSize size;

            public SizeView(CGSize size) : base()
            {
                this.size = size;
            }



            public override CGSize IntrinsicContentSize
            {
                get
                {
                    return this.size;
                }
            }
        }
    }
}