using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ISkillService
    {
        Task<Object> Get();
    }
}
