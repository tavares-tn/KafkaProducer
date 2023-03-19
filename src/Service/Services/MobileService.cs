using Domain.Interfaces.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MobileService : IMobileService
    {
        /// <summary>
        /// Busca dados na API
        /// </summary>
        /// <returns></returns>
        public async Task<Object> Get()
        {
            var client = new HttpClient();

            var request = await client.GetStringAsync("http://localhost:5000/api/v1/Examples");

            return request;
        }
    }
}
