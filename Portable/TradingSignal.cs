using System;
using System.Collections.Generic;
using System.Text;

namespace Portable
{
    public class TradingSignal
    {
        public int Id { get; set; }
        public string ActualTime { get; set; }
        public string Comment { get; set; }
        public string Pair { get; set; }
        public int Cmd { get; set; }
        public int TradingSystem { get; set; }
        public string Period { get; set; }
        public double Price { get; set; }
        public double Sl { get; set; }
        public double Tp { get; set; }
        public TradingSignal(int id, string actualtime, string comment, string pair, int cmd, int tradingsystem, string period, double price, double sl, double tp)
        {
            Id = id;ActualTime = actualtime; Comment = comment;Pair = pair;Cmd = cmd; TradingSystem = tradingsystem;Period = period; Price = price;Sl = sl;Tp = tp;
        }
    }
}
