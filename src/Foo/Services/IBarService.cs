using System.Threading.Tasks;

namespace Foo.Services
{
    public interface IBarService
    {
        Task<string> GetBarAsync();
    }
}
