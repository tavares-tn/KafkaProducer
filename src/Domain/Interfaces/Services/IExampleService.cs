using Domain.DTOs;
using Domain.DTOs.Request;
using Domain.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IExampleService
    {
        /// <summary>
        /// Retorna um registro pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ExampleDto> Get(Guid id);

        /// <summary>
        /// Retorna todos os registros
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ExampleDto>> GetAll(); 
        
        /// <summary>
        /// Cria um registro
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        Task<ResponseExampleDto> Post (RequestExampleDto example);

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        Task<ResponseExampleDto> Put(ExampleDto example);

        /// <summary>
        /// Remove um registro (delete lógico)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(Guid id);
    }
}
