using Foundation;
using SQLite;
using System;
using System.IO;
using System.Text.RegularExpressions;
using UIKit;
using Xamarin.Essentials;

namespace IosHelloApp
{
    public partial class ChangePasswordViewController : UIViewController
    {
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDBFolder.db3");
        string email = Preferences.Get("myEmail", "");
        UIAlertController okAlertController;
        string alertMessage;

        public ChangePasswordViewController() { }

        public ChangePasswordViewController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        partial void SaveButton_TouchUpInside(UIButton sender)
        {
            var db = new SQLiteConnection(dbPath);
            var getData = db.Get<User>(email);
            if(currentPassword.Text=="" || newPassword.Text == "")
            {
                alertMessage = "Enter the password";
                ErrorAlert();
                return;
            }
            else if (currentPassword.Text != getData.Password)
            {
                alertMessage = "Enter the correct current password";
                ErrorAlert();
                return;
            }
            else if (!Regex.Match(newPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$").Success)
            {
                alertMessage = "Invalid Password";
                ErrorAlert();
                return;
            }

            db.Update(
                new User()
                {
                    Email = getData.Email,
                    Name = getData.Name,
                    Phone = getData.Name,
                    Password = newPassword.Text
                });

            alertMessage = "Password Changed";
            ErrorAlert();
            currentPassword.Text = "";
            newPassword.Text = "";
        }

        public void ErrorAlert()
        {
            okAlertController = UIAlertController.Create(null, alertMessage, UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(okAlertController, true, null);

        }
    }
}