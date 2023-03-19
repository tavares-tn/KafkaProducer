using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IExternalService
    {
        Task<Object> Get();
    }
}
