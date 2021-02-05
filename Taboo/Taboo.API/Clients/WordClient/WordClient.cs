using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Taboo.API.Clients.Models;
using Taboo.Core.Models;

namespace Taboo.API.Clients.WordClient
{
    public class WordClient : BaseClient, IWordClient
    {
        private readonly HttpClient _httpClient;
        public WordClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ResultClientModel<Word>> GetAllWithTabusAsync()
        {
            var url = $"https://localhost:44383/api/word"; //I Am not Sure ??

            var response = await _httpClient.GetAsync(url);
            return await BindResultClientModel<Word>(response);
        }
    }
}
