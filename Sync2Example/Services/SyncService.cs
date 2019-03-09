using Newtonsoft.Json;
using RestSharp;
using Sync2Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync2Example.Services
{
    public class SyncService
    {
        private RestClient _client;

        public SyncService()
        {
            _client = new RestClient("https://localhost:44305/");
        }

        public ICollection<SchemaDefinition> PullSchemas()
        {

            var request = new RestRequest("api/SchemaDefinitions", Method.GET);
            request.JsonSerializer = new Serializers.JsonSerializer();

            var response = _client.Execute(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<SchemaDefinition>>(response.Content);
            }
            return null;
        }

        public ICollection<DynamicEntity> PullData()
        {

            var request = new RestRequest("api/dynamicentities", Method.GET);
            request.JsonSerializer = new Serializers.JsonSerializer();

            var response = _client.Execute(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<DynamicEntity>>(response.Content);
            }
            return null;
        }
    }
}
