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
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel laPass { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tf_Login { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tf_Password { get; set; }

        [Action ("BtnLogin_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLogin_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnLogin != null) {
                btnLogin.Dispose ();
                btnLogin = null;
            }

            if (laPass != null) {
                laPass.Dispose ();
                laPass = null;
            }

            if (tf_Login != null) {
                tf_Login.Dispose ();
                tf_Login = null;
            }

            if (tf_Password != null) {
                tf_Password.Dispose ();
                tf_Password = null;
            }
        }
    }
}