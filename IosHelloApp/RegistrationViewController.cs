using Foundation;
using System;
using UIKit;
using SQLite;
using System.IO;
using System.Text.RegularExpressions;

namespace IosHelloApp
{

    

    public partial class RegistrationViewController : UIViewController
    {
        UIAlertController okAlertController;
        string alertMessage;
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDBFolder.db3");
        public RegistrationViewController()
        {

        }
        public RegistrationViewController (IntPtr handle) : base (handle)
        {

        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.SetHidesBackButton(true, false);
            
        }

        partial void RegisterUserButton_TouchUpInside(UIButton sender)
        {

            ValidateUserDetails();
            RegisterNewUser();
        }

        
        public void ValidateUserDetails()
        {

            var name = userNameTextField.Text;
            var email = emailTextField.Text;
            var phone = phoneTextField.Text;
            var pass = passwordTextField.Text;

            if (email == "" || phone == "" || name == "" || pass == "")
            {
                alertMessage = "Enter the details";
                ErrorAlert();
                return;
            }
            else if (!Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$").Success)
            {
                alertMessage = "Invalid Email";
                ErrorAlert();
                return;
            }
            else if (!Regex.Match(phone, @"^([0-9]{10})$").Success)
            {
                alertMessage = "Invalid Phone number";
                ErrorAlert();
                return;
            }
            else if (!Regex.Match(pass, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$").Success)
            {
                alertMessage = "Invalid Password";
                ErrorAlert();
                return;
            }

        }

        public void RegisterNewUser()
        {
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<User>();
            User user = new User()
            {
                Name = userNameTextField.Text,
                Email = emailTextField.Text,
                Phone = phoneTextField.Text,
                Password = passwordTextField.Text

            };


            var findData = db.Find<User>(emailTextField.Text);
            if (findData != null)
            {
                alertMessage = "User already registered";
                ErrorAlert();
                return;
            }

            db.Insert(user);

            UIStoryboard storyboard = Storyboard;
            LoginViewController loginViewController = (LoginViewController)
                storyboard.InstantiateViewController("LoginViewController");
            NavigationController.PushViewController(loginViewController, true);

            alertMessage = user.Name + " registered.Please login to continue.";
            ErrorAlert();

        }

        public void ErrorAlert()
        {
            okAlertController = UIAlertController.Create(null, alertMessage, UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(okAlertController, true, null);

        }


    }
}

