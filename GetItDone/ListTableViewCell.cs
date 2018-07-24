using System;

using Foundation;
using UIKit;

namespace GetItDone
{
    public partial class ListTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("ListTableViewCell");
        public static readonly UINib Nib;

        static ListTableViewCell()
        {
            Nib = UINib.FromName("ListTableViewCell", NSBundle.MainBundle);
        }

        protected ListTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
