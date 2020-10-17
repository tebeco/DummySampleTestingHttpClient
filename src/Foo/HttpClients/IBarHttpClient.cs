using System.Threading.Tasks;

namespace Foo.HttpClients
{
    public interface IBarHttpClient
    {
        Task<string> GetBarAsync();
    }
}
