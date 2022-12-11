using CalcForm.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    public class API
    {
        static HttpClient client = new HttpClient();

        public API()
        {
                // Update port # in the following line.
                client.BaseAddress = new Uri("https://localhost:44387/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

            }
        public  ResultCalculation Calc(CalcInfo info)
        {
            var response =  client.PostAsJsonAsync("api/Calculate", info).Result;
            var jsonString = response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ResultCalculation>(jsonString.Result);
        }
        public  Dictionary<int, string> GetOperations()
        {
            var response =  client.GetAsync("api/Calculate").Result;
            return response.Content.ReadAsAsync<Dictionary<int, string>>().Result;
        }
    }
}
