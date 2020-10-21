using Foundation;
using System;
using UIKit;

namespace IosHelloApp
{
    public partial class TabBarController : UITabBarController
    {
        public TabBarController()
        {

        }
        public TabBarController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.SetHidesBackButton(true, false);

        }
        
    }
}