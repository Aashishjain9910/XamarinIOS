using Foundation;
using System;
using UIKit;
using Xamarin.Essentials;

namespace IosHelloApp
{
    public partial class GalleryViewController : UIViewController
    {

        UIImagePickerController imagePicker;

        public GalleryViewController (IntPtr handle) : base (handle)
        {
        }

        partial void PickImages_TouchUpInside(UIButton sender)
        {
            imagePicker = new UIImagePickerController();
            imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary);

            imagePicker.FinishedPickingMedia += Handle_FinishedPickingMedia;
            imagePicker.Canceled += ImagePicker_Canceled;

            NavigationController.PresentModalViewController(imagePicker, true);

        }

        void ImagePicker_Canceled(object sender, EventArgs e)
        {
            Console.WriteLine("Media Picker Cancelled");
            imagePicker.DismissModalViewController(true);

        }

        private void Handle_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {

            bool isImage = false;

            switch(e.Info[UIImagePickerController.MediaType].ToString())
            {
                case "public.image":
                    Console.WriteLine("Image Selected");
                    isImage = true;
                    break;
                case "public.video":
                    Console.WriteLine("Video Selected");
                    break;
            }

            Console.Write("Reference URL: [" + UIImagePickerController.ReferenceUrl + "]");

            NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerReferenceURL")] as NSUrl;
            if (referenceURL != null)
            {
                Console.WriteLine(referenceURL.ToString());
            }

            if (isImage)
            {
                UIImage originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
                if (originalImage != null)
                {
                    Console.WriteLine("Got the original image");
                    imageView.Image = originalImage;
                }

            /*    UIImage editedImage = e.Info[UIImagePickerController.EditedImage] as UIImage;
                if (editedImage != null)
                {
                    Console.WriteLine("Got the edited image");
                    imageView.Image = editedImage;
                }
            */
            }
            else
            {
                NSUrl mediaURL = e.Info[UIImagePickerController.MediaURL] as NSUrl;
                if (mediaURL != null)
                {
                    Console.WriteLine(mediaURL.ToString());
                }
            }


            imagePicker.DismissModalViewController(true);
        }
    }
}