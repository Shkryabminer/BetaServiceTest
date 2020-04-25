using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TEST_IBT
{
    internal class AuthorizationService : IAuthorisation
    {
        const string url = "http://client-api.instaforex.com/api/Authentication/RequestMoblieCabinetApiToken";
       public string Tocken { get; set; }
        string Password { get; set; }
       public string Login { get; set; }

        static public AuthorizationService service;

       protected  AuthorizationService() { }

        public static AuthorizationService GetService()
        {
            if (service == null)
                service = new AuthorizationService();
            return service;
        }


        public async Task<string> GetToken(string login, string password)
        {
            Login = login;
            Password = password;
            HttpClient client = new HttpClient();
            var content = GetContent(login, password);
           // HttpResponseMessage response = await client.GetAsync(url, content);
            HttpResponseMessage response = await client.PostAsync(url, content);
           

            HttpContent responseContent = response.Content;
            string tocken = await responseContent.ReadAsStringAsync();
            Tocken = tocken;
            return tocken;
        }

        private HttpContent GetContent(string login, string password)
        {
            Request request = new Request(login, password);
            var jsoncontent = ConvertToJSON(request);
            var content = new StringContent(jsoncontent, Encoding.UTF8, "application/json");
            return content;
        }
        private string ConvertToJSON(Request request)
        {
            string json = JsonConvert.SerializeObject(request);
            return json;
        }

       
    }
}