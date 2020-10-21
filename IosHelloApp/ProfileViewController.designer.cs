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
    [Register ("ProfileViewController")]
    partial class ProfileViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton editButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField profileEmailText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField profileNameText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField profilePhoneText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton updateButton { get; set; }

        [Action ("EditButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void EditButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UpdateButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UpdateButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (editButton != null) {
                editButton.Dispose ();
                editButton = null;
            }

            if (profileEmailText != null) {
                profileEmailText.Dispose ();
                profileEmailText = null;
            }

            if (profileNameText != null) {
                profileNameText.Dispose ();
                profileNameText = null;
            }

            if (profilePhoneText != null) {
                profilePhoneText.Dispose ();
                profilePhoneText = null;
            }

            if (updateButton != null) {
                updateButton.Dispose ();
                updateButton = null;
            }
        }
    }
}