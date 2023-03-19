using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IMobileService
    {
        Task<Object> Get();
    }
}
