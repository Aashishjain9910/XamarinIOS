// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IosHelloApp
{
    [Register ("GalleryViewController")]
    partial class GalleryViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton pickImages { get; set; }

        [Action ("PickImages_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PickImages_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (imageView != null) {
                imageView.Dispose ();
                imageView = null;
            }

            if (pickImages != null) {
                pickImages.Dispose ();
                pickImages = null;
            }
        }
    }
}