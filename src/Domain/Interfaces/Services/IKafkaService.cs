
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IKafkaService
    {
        Task<bool> Post(string evento);
    }
}
