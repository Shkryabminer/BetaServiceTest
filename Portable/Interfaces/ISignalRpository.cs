using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portable
{
    interface ISignalRpository
    {
        List<TradingSignal> GetSignal();
      Task GetSignals(string tocken, string login);

    }
}
