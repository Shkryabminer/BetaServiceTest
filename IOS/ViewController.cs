using Foundation;
using System;
using TEST_IBT;
using UIKit;

namespace IOS
{
    public partial class ViewController : UIViewController,ILoginView
    {
        Presenter_Main _presenter;
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
            _presenter = new Presenter_Main(this);

        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        public void TranslateSignal(string signal)
        {
            var VC = Storyboard.InstantiateViewController("signalsView") as UISignalsViewController;
            VC.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;
            PresentViewController(VC,false, null);
        }

        partial void BtnLogin_TouchUpInside(UIButton sender)
        {
            var login = tf_Login.Text;
            var password = tf_Password.Text;
            _presenter.GetAuthorization(login, password);
        }
    }
}