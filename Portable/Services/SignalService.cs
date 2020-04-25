using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace TEST_IBT
{
    class SignalService : ISignal
    {
       // const string url = "http://client-api.instaforex.com/clientmobile/GetAnalyticSignals/PARTNERS_LOGIN?tradingsystem=3&pairs=EURUSD,GBPUSD,USDJPY,USDCHF,USDCAD,AUDUSD,NZDUSD&from=UNIX_DATE&to=UNIX_DATE";
        const string url = "http://client-api.instaforex.com/clientmobile/GetAnalyticSignals/";
        public async Task<string> GetSignalAsync(string tocken, string login)
        {
            HttpClient client = new HttpClient();
             client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Add("passkey", tocken);
            string link = login + "?tradingsystem=3&pairs=EURUSD,GBPUSD,USDJPY,USDCHF,USDCAD,AUDUSD,NZDUSD&from=1479860023&to=1480066860";
            
            HttpResponseMessage response = await client.GetAsync(link);            
           
            Console.WriteLine(response.StatusCode);            
            HttpContent content = response.Content;
            string signals = await content.ReadAsStringAsync();
            //Console.WriteLine(signals);
            return signals;
        }
        
    }
}