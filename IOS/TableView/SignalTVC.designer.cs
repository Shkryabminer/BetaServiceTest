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

namespace IOS
{
    [Register ("SignalTVC")]
    partial class SignalTVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_ID { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_Pair { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_Period { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lb_ID != null) {
                lb_ID.Dispose ();
                lb_ID = null;
            }

            if (lb_Pair != null) {
                lb_Pair.Dispose ();
                lb_Pair = null;
            }

            if (lb_Period != null) {
                lb_Period.Dispose ();
                lb_Period = null;
            }
        }
    }
}