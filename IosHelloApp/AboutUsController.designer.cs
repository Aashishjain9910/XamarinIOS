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
    [Register ("AboutUsController")]
    partial class AboutUsController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView myPageScroller { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPageControl pageControlDots { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (myPageScroller != null) {
                myPageScroller.Dispose ();
                myPageScroller = null;
            }

            if (pageControlDots != null) {
                pageControlDots.Dispose ();
                pageControlDots = null;
            }
        }
    }
}