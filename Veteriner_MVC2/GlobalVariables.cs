using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Veteriner_MVC2
{
    public class GlobalVariables
    {
        public static HttpClient WebApClient = new HttpClient();

        static GlobalVariables()
        {
            WebApClient.BaseAddress = new Uri("https://localhost:44333/api/");
            WebApClient.DefaultRequestHeaders.Clear();
            WebApClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}