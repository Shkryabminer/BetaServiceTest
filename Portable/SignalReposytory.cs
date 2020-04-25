using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEST_IBT;

namespace Portable
{
   public class SignalReposytory:ISignalRpository
    {
        static SignalReposytory signalReposytory;
        static  List<TradingSignal> signalList;
      private  SignalService signalService;
        IAdapter adapter;
       
        public SignalReposytory()
        { }
       static public SignalReposytory GetReposytory()
        {
            if (signalReposytory == null)
                signalReposytory = new SignalReposytory();
            return signalReposytory;
        }
        public  List<TradingSignal> GetSignal()
        {
          return signalList;
        }

        public async Task GetSignals(string tocken, string login)
        {
            signalService = new SignalService();
            var signals = await signalService.GetSignalAsync(tocken,login);
            adapter = new Adapter();
            signalList = adapter.ConvertSignals(signals);
            //if (signalList == null)
            //    signalList = new List<TradingSignal>();
           // return signalList;
        }
        
        public void ResetSignals()
        {
            signalList = new List<TradingSignal>();
        }
    }
}
