using Newtonsoft.Json;
using RailWaveTrack.Modal;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RailWaveTrack.Services
{
    public class RestServices : IRestServices
    {
        public const string ApiKey = "lu5t3wsttz";

        HttpClient client = null;

        public RestServices()
        {
            client = new HttpClient();
            //client.MaxResponseContentBufferSize = 250000;
        }       

        public async Task<PNRRootobject> RefreshDataAsync(string pnrNumber)
        {            
            PNRRootobject pNRRootobject = null;
            try
            {
                string url = $"https://api.railwayapi.com/v2/pnr-status/pnr/{pnrNumber}/apikey/{ApiKey}/";
                var response = await client.GetAsync(new Uri(url));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    pNRRootobject = JsonConvert.DeserializeObject<PNRRootobject>(content);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return pNRRootobject;
        }
    }
}
