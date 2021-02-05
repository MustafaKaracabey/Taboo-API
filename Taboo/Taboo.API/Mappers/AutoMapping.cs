using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taboo.API.DTOs;
using Taboo.Core.Models;

namespace Taboo.API.Mappers
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            //Domain To Resource
            CreateMap<Tabu, TabuDTO>();
            CreateMap<Word, WordDTO>();

            //Resource To Domain
            CreateMap<TabuDTO, Tabu>();
            CreateMap<WordDTO, Word>();
        }
    }
}
