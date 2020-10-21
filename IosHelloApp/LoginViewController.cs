using Foundation;
using System;
using UIKit;
using SQLite;
using System.IO;
using Xamarin.Essentials;

namespace IosHelloApp
{
    public partial class LoginViewController : UIViewController
    {
        UIAlertController okAlertController;

        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDBFolder.db3");

        public LoginViewController()
        {

        }
        public LoginViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.SetHidesBackButton(true, false);
        }

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            var email = emailTextField.Text;
            var pass = passwordTextField.Text;
            var db = new SQLiteConnection(dbPath);

            //var findData = db.Find<User>(email);
            if (db.Find<User>(email) == null)
            {
                okAlertController = UIAlertController.Create("Error", "Email not exist", UIAlertControllerStyle.Alert);
                ErrorAlert();
                return;
            }


            var getData = db.Get<User>(email);
            if (email == "" || pass == "")
            {
                okAlertController = UIAlertController.Create("Error", "Please enter email/password", UIAlertControllerStyle.Alert);
                ErrorAlert();
                return;
            }
            else if (getData.Password != pass)
            {
                okAlertController = UIAlertController.Create("Error", "Invalid email/password", UIAlertControllerStyle.Alert);
                ErrorAlert();
                return;
            }
            AddValue("myEmail", email);
            UIStoryboard storyboard = this.Storyboard;
            TabBarController tabBarController = (TabBarController)
                storyboard.InstantiateViewController("TabBarController");
            NavigationController.PushViewController(tabBarController, true);



            //NavigationController.PopToViewController(new TabBarController(), true);
            //PerformSegue("toLoginSegue", null);


        }

        public void AddValue(string key, string value)
        {
            Preferences.Set(key, value);
        }

        public void ErrorAlert()
        {

            okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(okAlertController, true, null);

        }




    }
}