using AutoMapper;
using Sync2Example.DTOs;
using Sync2Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync2Example.AutoMapper.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<DynamicEntity, DynamicEntityDTO>()
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectTable.ProjectId))
                .ReverseMap();

            CreateMap<SchemaDefinition, SchemaDefinitionDTO>()
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectTable.ProjectId))
                .ReverseMap();
        }
    }
}
