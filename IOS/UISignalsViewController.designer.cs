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
    [Register ("UISignalsViewController")]
    partial class UISignalsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView _tableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_tableView != null) {
                _tableView.Dispose ();
                _tableView = null;
            }
        }
    }
}