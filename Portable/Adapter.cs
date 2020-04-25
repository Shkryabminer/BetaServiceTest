using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable
{
    class Adapter : IAdapter
    {
        public List<TradingSignal> Signals { get; private set; }
        public List<TradingSignal> ConvertSignals(string json)
        {
            Signals = new List<TradingSignal>();
            var signals = JsonConvert.DeserializeObject<List<TradingSignal>>(json);
            foreach (var signal in signals)
            {
                Signals.Add(signal);
            }
            return Signals;
        }
    }
}
