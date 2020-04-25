using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace TEST_IBT
{
    public class Presenter_Main
    {
        AuthorizationService authorisator;
        SignalService signalservice;
        private string tocken;
        private string _signals;
        ILoginView activityContext;
        public string Signal
        {
            get { return _signals; }
            set { if (value != null)
                {
                    _signals = value;
                    activityContext.TranslateSignal(Signal);
                }
              }
        }
        
        public Presenter_Main(ILoginView context)
        {
            activityContext = context;
        }
        public async void GetAuthorization(string login, string password)
        {
            if (tocken == null)
            {
                authorisator = AuthorizationService.GetService();
                tocken = await authorisator.GetToken(login, password);
            }            
              GetSignals(tocken, login);           
                       
        }

        private async void GetSignals(string tocken, string login)
        {
            if (tocken !=null)
            {
                signalservice = new SignalService();
                Signal = await signalservice.GetSignalAsync(tocken, login);
            }
        }
    }
}