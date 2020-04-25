using Foundation;
using Portable;
using System;
using UIKit;

namespace IOS
{
    public partial class SignalTVC : UITableViewCell
    {
        public SignalTVC (IntPtr handle) : base (handle)
        {
        }
        public SignalTVC()
        { }

        internal void UpdateCell(TradingSignal item)
        {
            lb_ID.Text = item.Id.ToString();
            lb_Pair.Text = item.Pair;
            lb_Period.Text = item.Period;

        }
    }
}