using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taboo.API.DTOs;
using Taboo.Core.Services;



namespace Taboo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IWordService _wordService;
        private readonly IMapper _mapper;

        public WordController(IWordService wordService, IMapper mapper)
        {
            _wordService = wordService;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllWithTabusAsync()
        {
            var words = await _wordService.GetAllWithTabusAsync();

            return Ok(_mapper.Map<IEnumerable<WordDTO>>(words));
        }

    }
}
