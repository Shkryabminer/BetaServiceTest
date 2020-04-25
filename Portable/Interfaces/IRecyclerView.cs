using System;
using System.Collections.Generic;
using System.Text;

namespace Portable
{
   public interface IRecyclerView
    {
        void SetSignals(List<TradingSignal> model);
    }
}
