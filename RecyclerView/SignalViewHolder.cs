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
using Android.Support.V7.Widget;
namespace TEST_IBT
{
    internal class SignalViewHolder : RecyclerView.ViewHolder
    {
       public TextView ID { get; private set; }
        public TextView PairValue { get; private set; }
        public TextView Period { get; private set; }
        
        public SignalViewHolder(View itemView, Action<int> action) : base(itemView)
        {
            ID = itemView.FindViewById<TextView>(Resource.Id.tv_id_signal);
            PairValue = itemView.FindViewById<TextView>(Resource.Id.tv_pairValue);
            Period = itemView.FindViewById<TextView>(Resource.Id.tv_timeFrame_Value);
            itemView.Click += (o, e) => action(LayoutPosition);
        }
    }
}