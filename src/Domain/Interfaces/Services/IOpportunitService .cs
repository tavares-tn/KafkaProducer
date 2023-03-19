using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IOpportunitService
    {
        Task<Object> Get();
    }
}
