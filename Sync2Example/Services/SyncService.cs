using AutoMapper;
using Newtonsoft.Json;
using RestSharp;
using Sync2Example.AutoMapper.Profiles;
using Sync2Example.DTOs;
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
        private IMapper _mapper;

        public SyncService()
        {
            _client = new RestClient("https://localhost:44305/");
            _mapper = new Mapper(new MapperConfiguration(config => config.AddProfile(new MappingProfile())));
        }

        public ICollection<SchemaDefinition> PullSchemas()
        {

            var request = new RestRequest("api/SchemaDefinitions", Method.GET);
            request.JsonSerializer = new Serializers.JsonSerializer();

            var response = _client.Execute(request);

            if (response.IsSuccessful)
            {
                var dtos = JsonConvert.DeserializeObject<List<SchemaDefinitionDTO>>(response.Content);
                return _mapper.Map<ICollection<SchemaDefinition>>(dtos);
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
                var dtos = JsonConvert.DeserializeObject<List<DynamicEntityDTO>>(response.Content);
                return _mapper.Map<ICollection<DynamicEntity>>(dtos);
            }
            return null;
        }
    }
}
