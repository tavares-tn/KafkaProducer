using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {
        /// <summary>
        /// Inserir registro no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<T> Insert(T item);

        /// <summary>
        /// Atualiza um registro no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<T> Update(T item);

        /// <summary>
        /// Remove um registro (delete lógico)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(Guid id);

        /// <summary>
        /// Busca um registro pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> Select(Guid id);

        /// <summary>
        /// Busca a lista de todos os registros do banco
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> Select();
    }
}
