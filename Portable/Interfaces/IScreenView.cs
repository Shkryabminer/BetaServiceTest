using System;
using System.Collections.Generic;
using System.Text;

namespace Portable
{
    public interface IScreenView
    {
        void SetSignal(TradingSignal signal);
    }
}
