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
    [Register ("ContactUsController")]
    partial class ContactUsController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MyOfficeReceptionImage { get; set; }

        [Action ("UIButton58316_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton58316_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton58317_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton58317_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton58318_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton58318_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (MyOfficeReceptionImage != null) {
                MyOfficeReceptionImage.Dispose ();
                MyOfficeReceptionImage = null;
            }
        }
    }
}