using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Portable;
namespace TEST_IBT
{
    [Activity(Label = "SignalScreen")]
    public class SignalScreen : Activity, IScreenView
    {
        IScreenPresenter _presenter;

        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_signal);
            _presenter = new ScreenPresenter(this);
            SetData();         
            // Create your application here
        }

        private  void SetData()
        {
            int position = Intent.GetIntExtra("number",-1);
            if(position>=0)
            _presenter.GetSignal(position);    
        }
        public void SetSignal(TradingSignal signal)
        {
            TextView id = FindViewById<TextView>(Resource.Id.tv_ID_Value);
            id.Text = signal.Id.ToString();
            TextView actualTime = FindViewById<TextView>(Resource.Id.tv_Act_Time_Value);
            actualTime.Text = signal.ActualTime;
            TextView comment = FindViewById<TextView>(Resource.Id.tv_comment_Value);
            comment.Text = signal.Comment;
            TextView pair = FindViewById<TextView>(Resource.Id.tv_pair_Value);
            pair.Text = signal.Pair;
            TextView cmd = FindViewById<TextView>(Resource.Id.tv_cmd_Value);
            cmd.Text = signal.Cmd.ToString();
            TextView system = FindViewById<TextView>(Resource.Id.tv_trading_System_Value);
            system.Text = signal.TradingSystem.ToString();
            TextView period = FindViewById<TextView>(Resource.Id.tv_period_Value);
            period.Text = signal.Period;
            TextView price = FindViewById<TextView>(Resource.Id.tv_price_Value);
            price.Text = Math.Round(signal.Price, 5).ToString();
            TextView sl = FindViewById<TextView>(Resource.Id.tv_sl_Value);
            sl.Text = Math.Round(signal.Sl, 5).ToString();
            TextView tp = FindViewById<TextView>(Resource.Id.tv_tp_Value);
            tp.Text = Math.Round(signal.Tp, 5).ToString();
        }
    }
}