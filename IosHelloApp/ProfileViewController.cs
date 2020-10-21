using Foundation;
using SQLite;
using System;
using System.IO;
using System.Text.RegularExpressions;
using UIKit;
using Xamarin.Essentials;

namespace IosHelloApp
{
    public partial class ProfileViewController : UIViewController
    {

        UIAlertController okAlertController;
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDBFolder.db3");
        string email = Preferences.Get("myEmail", "");
        string alertMessage;

        public ProfileViewController(){}

        public ProfileViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var db = new SQLiteConnection(dbPath);

            var getData = db.Get<User>(email);
            profileEmailText.Text = getData.Email;
            profileNameText.Text = getData.Name;
            profilePhoneText.Text = getData.Phone;

        }

        partial void EditButton_TouchUpInside(UIButton sender)
        {
            //profileEmailText.Enabled = true;
            profileNameText.Enabled = true;
            profilePhoneText.Enabled = true;
            updateButton.Enabled = true;
            //profileNameText.Focused = true;
            editButton.Enabled = false;
        }

        partial void UpdateButton_TouchUpInside(UIButton sender)
        {
            ValidateUserDetails();
            UpdateUserDetails();

        }


        public void ValidateUserDetails()
        {

            var name = profileNameText.Text;
            var phone = profilePhoneText.Text;
            

            if (phone == "" || name == "")
            {
                alertMessage = "Enter your Name and Phone Number";
                ErrorAlert();
                return;
            }
            else if (!Regex.Match(phone, @"^([0-9]{10})$").Success)
            {
                alertMessage = "Invalid Phone number";
                ErrorAlert();
                return;
            }
            
        }

        public void UpdateUserDetails()
        {
            var db = new SQLiteConnection(dbPath);
            var getData = db.Get<User>(email);

            db.Update(
                new User()
                {
                    Email = profileEmailText.Text,
                    Name = profileNameText.Text,
                    Phone = profilePhoneText.Text,
                    Password = getData.Password

                });
            alertMessage = "Profile updated";
            ErrorAlert();
            editButton.Enabled = true;
            updateButton.Enabled = false;


        }

        public void ErrorAlert()
        {
            okAlertController = UIAlertController.Create(null, alertMessage, UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(okAlertController, true, null);

        }

    }
}

