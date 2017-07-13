using System;

using Foundation;
using UIKit;

namespace AutoSizeRowHeight
{
    public partial class GrowRowTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("GrowRowTableViewCell");
        public static readonly UINib Nib;

        static GrowRowTableViewCell()
        {
            Nib = UINib.FromName("GrowRowTableViewCell", NSBundle.MainBundle);
        }


		public UIImage Image
		{
			get { return cellImage.Image; }
			set { cellImage.Image = value; }
		}

        public string Title {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string Description {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value ; }
        }

        protected GrowRowTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
