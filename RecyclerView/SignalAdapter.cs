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
    class SignalAdapter : RecyclerView.Adapter
    {
        List<TradingSignal> _data;
        Action<int> _action;
        public SignalAdapter(List<TradingSignal> data, Action<int> action)
        {
            _data = data;
            _action = action;
        }
        public SignalAdapter() { }

        public override int ItemCount
        {
            get
            {
                int count = 0;
                if (_data != null)
                    count = _data.Count;
                return count;
            }
        }
        public void RefreshData(List<TradingSignal> newmodel)
        {
            _data = newmodel;
            this.NotifyDataSetChanged();
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var signalHolder = holder as SignalViewHolder;
           
            signalHolder.ID.Text = _data[position].Id.ToString();
           
           
            signalHolder.Period.Text = _data[position].Period.ToUpper();
            
            signalHolder.PairValue.Text = _data[position].Pair.ToUpper();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.activity_viewholder,parent,false);
            var vh = new SignalViewHolder(itemView, _action);
            return vh;
        }
    }
}