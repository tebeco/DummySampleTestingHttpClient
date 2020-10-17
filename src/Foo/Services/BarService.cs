using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foo.HttpClients;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Foo.Services
{
    public class BarService : IBarService
    {
        private readonly IBarHttpClient _barHttpClient;

        public BarService(IBarHttpClient barHttpClient)
        {
            _barHttpClient = barHttpClient;
        }

        public async Task<string> GetBarAsync()
        {
            return await _barHttpClient.GetBarAsync();
        }
    }
}
