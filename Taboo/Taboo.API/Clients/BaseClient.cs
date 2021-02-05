using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Taboo.API.Clients.Models;
using Taboo.API.Extensions;

namespace Taboo.API.Clients
{
    public class BaseClient
    {
        public async Task<ResultClientModel<T>> BindResultClientModel<T>(HttpResponseMessage httpResponseMessage)
        {
            ResultClientModel<T> resultClientModel = new ResultClientModel<T>();

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                string content = await httpResponseMessage.Content.ReadAsStringAsync();

                resultClientModel.Data = content.DeserializeJsonToObject<T>();

                return resultClientModel;
            }
            else if (httpResponseMessage.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new Exception();
            }

            return resultClientModel;
        }
    }
}
