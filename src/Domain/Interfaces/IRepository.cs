using Domain.Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {

        Task<bool> Insert(string mensagem);
    }
}
