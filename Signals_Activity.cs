using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Portable;

namespace TEST_IBT
{
    [Activity(Label = "Signals_Activity")]
    public class Signals_Activity : Activity,IRecyclerView
    {
        RecyclerView signalRecyclerView;
        List<TradingSignal> _data;
        public List<TradingSignal> Data {
            get { return _data; }
            set {                
                _data = value;
                Console.WriteLine("new data seted");                
                _sadapter.RefreshData(Data);
            }
        }
        SignalAdapter _sadapter;
        Action<int> action;
        SignalPresenter _signaPresenter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_recyclerView);
            _signaPresenter = new SignalPresenter(this);

            

            signalRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            action += ShowSignal;
            _sadapter = new SignalAdapter(Data, action);
            LinearLayoutManager manager = new LinearLayoutManager(this.BaseContext);
            signalRecyclerView.SetAdapter(_sadapter);
            signalRecyclerView.SetLayoutManager(manager);
            _signaPresenter.GetSignal();

            // Create your application here
        }




        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);
        //    SetContentView(Resource.Layout.activity_recyclerView);
        //    _signaPresenter = new SignalPresenter(this);
            
        //    _signaPresenter.GetSignal(Intent.GetStringExtra("signals"));
            
        //    signalRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
        //    action += ShowSignal;
        //    _sadapter = new SignalAdapter(Data,action);
        //    LinearLayoutManager manager= new LinearLayoutManager(this.BaseContext);
        //    signalRecyclerView.SetAdapter(_sadapter);
        //    signalRecyclerView.SetLayoutManager(manager);
           
        //    // Create your application here
        //}
       
        public void ShowSignal(int position)
        {            
            Intent intent = new Intent(this.BaseContext, typeof(SignalScreen));
            intent.PutExtra("number",position);           
            this.StartActivity(intent);
        }

        public void SetSignals(List<TradingSignal> model)
        {
            Data = model;
        }
    }
}