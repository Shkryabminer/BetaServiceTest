using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEST_IBT;

namespace Portable
{
   public class SignalPresenter
    {
        IRecyclerView _view;
        private List<TradingSignal> model;
        SignalReposytory reposytory;
        public SignalPresenter(IRecyclerView view)
        {
            _view = view;           
        }


        public async Task GetSignal()
        {
            reposytory = SignalReposytory.GetReposytory();
            await reposytory.GetSignals(AuthorizationService.GetService().Tocken, AuthorizationService.GetService().Login);
            model = reposytory.GetSignal();
            _view.SetSignals(model);
        }
        //public void GetSignal(string signal)
        //{
        //    Adapter adapter = new Adapter();
        //    model = adapter.ConvertSignals(signal);
        //    _view.SetSignals(model);

        //}



    }
}
