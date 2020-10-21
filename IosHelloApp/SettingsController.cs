using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace IosHelloApp
{
    public partial class SettingsController : UIViewController
    {
        public SettingsController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            tableView = new UITableView(View.Bounds);

            UIView footerView = new UIView();
            tableView.TableFooterView = footerView;
            List<TableItem> tableItems = new List<TableItem>();

            tableItems.Add(new TableItem {Heading="Profile", ImageName = "Profile.png" });
            tableItems.Add(new TableItem { Heading = "Change Password", ImageName = "icon_password.png" });
            tableItems.Add(new TableItem { Heading = "Logout", ImageName = "Logout.png" });
            tableView.Source = new TableViewDataSource(tableItems, this);
            Add(tableView);

        }
    }
}


