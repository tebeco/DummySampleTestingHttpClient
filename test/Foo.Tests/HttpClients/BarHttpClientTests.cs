using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Foo.HttpClients.Tests
{
    public class BarHttpClientTests
    {
        [Theory]
        [InlineData("a")]
        [InlineData("b")]
        public async Task Should_GetBarAsync(string bar)
        {
            var handler = new MyHandler(bar);
            var httpClient = new HttpClient(handler);
            httpClient.BaseAddress = new Uri("https://localhost");
            var barHttpClient = new BarHttpClient(httpClient);
            
            var result = await barHttpClient.GetBarAsync();

            Assert.Equal($"foo {bar}", result);
        }
    }

    public class MyHandler : HttpMessageHandler
    {
        private readonly string _barResult;

        public MyHandler(string barResult)
        {
            _barResult = barResult;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent($"foo {_barResult}");
            return Task.FromResult(response);
        }
    }
}
