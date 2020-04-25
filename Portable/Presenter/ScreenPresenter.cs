using System;
using System.Collections.Generic;
using System.Text;

namespace Portable
{
   public class ScreenPresenter:IScreenPresenter
    {
        ISignalRpository _repository;
        IScreenView screenview;
        
        public ScreenPresenter(IScreenView view)
        {
            screenview = view;
        }

        public void GetSignal(int nomber)
        {
            var signal = SignalReposytory.GetReposytory().GetSignal()[nomber];
           screenview.SetSignal( signal);
        }
    }
}
