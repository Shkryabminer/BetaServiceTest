using Foundation;
using System;
using UIKit;
using Portable;

namespace IOS
{
    public partial class ScreenViewController : UIViewController, IScreenView
    {
        public int Nomber { get; set; } = -1;

        public ScreenViewController (IntPtr handle) : base (handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ScreenPresenter presenter = new ScreenPresenter(this);
          if(Nomber>=0)
            presenter.GetSignal(Nomber);
            
        }

        public void SetSignal(TradingSignal signal)
        {
            if (signal == null)
                return;
            lb_ID.Text = signal.Id.ToString();
            lb_ActualTime.Text = signal.ActualTime;
            lb_Comment.Text = signal.Comment;
            lb_Pair.Text = signal.Pair;
            lb_CMD.Text = signal.Cmd.ToString();
            lb_Price.Text = Math.Round(signal.Price, 5).ToString();
            lb_SL.Text = Math.Round(signal.Sl,5).ToString();
            lb_TP.Text = Math.Round(signal.Tp, 5).ToString();
            lb_TradingSystem.Text = signal.TradingSystem.ToString();
            lb_Period.Text = signal.Period;

        }

        partial void UIButton11666_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}