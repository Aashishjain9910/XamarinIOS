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
    [Register ("PortfolioController")]
    partial class PortfolioController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView digitalInsights { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView kredin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView netFacilities { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView petrics { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView surveyBuilder { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (digitalInsights != null) {
                digitalInsights.Dispose ();
                digitalInsights = null;
            }

            if (kredin != null) {
                kredin.Dispose ();
                kredin = null;
            }

            if (netFacilities != null) {
                netFacilities.Dispose ();
                netFacilities = null;
            }

            if (petrics != null) {
                petrics.Dispose ();
                petrics = null;
            }

            if (surveyBuilder != null) {
                surveyBuilder.Dispose ();
                surveyBuilder = null;
            }
        }
    }
}