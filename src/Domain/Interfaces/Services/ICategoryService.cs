using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<Object> Get();
    }
}
