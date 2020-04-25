using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TEST_IBT
{
    public interface IAuthorisation
    {
       Task<string> GetToken(string login, string password);
    }
}