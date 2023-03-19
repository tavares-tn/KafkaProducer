using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Object> Get();
    }
}
