using System.Threading.Tasks;

namespace Retina.Services
{
    public interface IApi<T>
    {
        Task<bool> Send(T scan);
    }
}