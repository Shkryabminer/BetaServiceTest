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
    [Register ("ScreenView")]
    partial class ScreenViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel at { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel id { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_ActualTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_CMD { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_Comment { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_ID { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_Pair { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_Period { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_Price { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_SL { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_TP { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lb_TradingSystem { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel period { get; set; }

        [Action ("UIButton11666_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton11666_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (at != null) {
                at.Dispose ();
                at = null;
            }

            if (id != null) {
                id.Dispose ();
                id = null;
            }

            if (lb_ActualTime != null) {
                lb_ActualTime.Dispose ();
                lb_ActualTime = null;
            }

            if (lb_CMD != null) {
                lb_CMD.Dispose ();
                lb_CMD = null;
            }

            if (lb_Comment != null) {
                lb_Comment.Dispose ();
                lb_Comment = null;
            }

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

            if (lb_Price != null) {
                lb_Price.Dispose ();
                lb_Price = null;
            }

            if (lb_SL != null) {
                lb_SL.Dispose ();
                lb_SL = null;
            }

            if (lb_TP != null) {
                lb_TP.Dispose ();
                lb_TP = null;
            }

            if (lb_TradingSystem != null) {
                lb_TradingSystem.Dispose ();
                lb_TradingSystem = null;
            }

            if (period != null) {
                period.Dispose ();
                period = null;
            }
        }
    }
}