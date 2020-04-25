using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_IBT
{
    interface ISignal
    {
       Task<string> GetSignalAsync(string tocken, string login);
    }
}