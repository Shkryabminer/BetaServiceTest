using System;
using System.Collections.Generic;
using System.Text;

namespace Portable
{
    interface IAdapter
    {
       List<TradingSignal> ConvertSignals(string json);
    }
}
