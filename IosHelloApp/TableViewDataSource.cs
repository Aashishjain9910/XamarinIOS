using System;
using System.IO;
using UIKit;
using Foundation;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace IosHelloApp
{
    public class TableViewDataSource : UITableViewSource
    {
        List<TableItem> tableItems;
        SettingsController owner;
        public TableViewDataSource(List<TableItem> items, SettingsController owner)
        {
            tableItems = items;

            this.owner = owner;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("cell_id");

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "cell_id");
            }

            cell.TextLabel.Text = tableItems[indexPath.Row].Heading;
            cell.ImageView.Image = UIImage.FromFile(tableItems[indexPath.Row].ImageName);
            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var selectedRow = tableItems[indexPath.Row].Heading;
            UIStoryboard storyboard = owner.Storyboard;
            if (selectedRow == "Profile")
            {
                ProfileViewController profileViewController = (ProfileViewController)
                    storyboard.InstantiateViewController("ProfileViewController");
                owner.NavigationController.PushViewController(profileViewController, true);
            }
            else if (selectedRow == "Logout")
            {
                Preferences.Remove("myEmail");

                LoginViewController loginViewController = (LoginViewController)
                    storyboard.InstantiateViewController("LoginViewController");
                owner.NavigationController.PushViewController(loginViewController, true);

            }
            else if(selectedRow=="Change Password")
            {
                ChangePasswordViewController changePasswordViewController = (ChangePasswordViewController)
                    storyboard.InstantiateViewController("ChangePasswordViewController");
                owner.NavigationController.PushViewController(changePasswordViewController, true);
            }

            //UIAlertController okAlertController = UIAlertController.Create("Row Selected", tableItems[indexPath.Row].Heading, UIAlertControllerStyle.Alert);
            //okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            //owner.PresentViewController(okAlertController, true, null);

            tableView.DeselectRow(indexPath, true);
        }



    }
}
