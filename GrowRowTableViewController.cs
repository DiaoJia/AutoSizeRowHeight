using Foundation;
using System;
using UIKit;

namespace AutoSizeRowHeight
{
    public partial class GrowRowTableViewController : UITableViewController
    {
        public GrowRowTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var tableSource = new GrowRowTableSource();

            TableView.RegisterNibForCellReuse(GrowRowTableViewCell.Nib,GrowRowTableViewCell.Key);

            TableView.Source = tableSource;

            TableView.EstimatedRowHeight = 40f;
            TableView.ReloadData();
        }
    }
}