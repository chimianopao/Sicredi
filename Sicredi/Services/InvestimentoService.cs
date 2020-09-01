using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sicredi.Services
{
    public class InvestimentoService
    {
        public IRestResponse GetService()
        {
            var client = new RestClient("http://5b847b30db24a100142dce1b.mockapi.io/api/v1/simulador");
            var RSrequest = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

            return client.Execute(RSrequest);
        }
    }
}
