using Foundation;
using System;
using UIKit;
using Xamarin.Essentials;

namespace IosHelloApp
{
    public partial class ContactUsController : UIViewController
    {
        public ContactUsController (IntPtr handle) : base (handle)
        {
        }

        partial void UIButton58318_TouchUpInside(UIButton sender)
        {
            var text = FromObject("Successive Technologies, Noida, UttarPradesh\nWebsite: https://successive.tech/ \nPhone No.: +911204269272");
            var image = FromObject(MyOfficeReceptionImage.Image);

            var items = new[] { image, text };

            var activity = new UIActivityViewController(items, null);

            PresentViewController(activity, true, null);
        }

        partial void UIButton58316_TouchUpInside(UIButton sender)
        {
            try
            {
                PhoneDialer.Open("01204269272");
            }
            catch (Exception ex)
            {
                UIAlertController okAlertController = UIAlertController.Create("Call Alert", "Can't connect the call", UIAlertControllerStyle.Alert);
                okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            }
        }

        partial void UIButton58317_TouchUpInside(UIButton sender)
        {
            double lat = 28.5994907;
            double lon = 77.3315516;
            Map.OpenAsync(lat, lon, new MapLaunchOptions
            {
                Name = "Successive Technologies, Noida, UttarPradesh",
                NavigationMode=NavigationMode.None,
            });
        }
    }
}