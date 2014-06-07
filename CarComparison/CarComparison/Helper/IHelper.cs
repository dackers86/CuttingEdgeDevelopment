using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CarComparison.Helpers
{
    public interface IHelper
    {
        object ExecuteHTTPClient<T>(string method, string source);
    }
}