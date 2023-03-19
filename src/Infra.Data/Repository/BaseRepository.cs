using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataSet;

        public BaseRepository(MyContext contex)
        {
            _context = contex;
            _dataSet = contex.Set<T>();
        }

        /// <summary>
        /// Remove um registro (delete lógico)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> Delete(Guid id)
        {
            try
            {
                // Busca registro banco
                var data = await _dataSet.SingleOrDefaultAsync(
                        d => d.Id.Equals(id) &&
                        !d.Deleted
                    );

                // Verifica se encontrou registro
                if (data == null)
                    return false;

                // Delete lógico
                data.Deleted = true;

                data.Updated = DateTime.UtcNow;

                // Atualizo os valores do contexo
                _context.Entry(data).CurrentValues.SetValues(data);

                // Persiste contexto(dados) em banco
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        /// <summary>
        /// Inserir registro no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<T> Insert(T item)
        {
            try
            {
                // Se item.Id for vazio, adiciona um Guid
                if (item.Id == Guid.Empty)
                    item.Id = Guid.NewGuid();

                // Adiciona a data de criação
                item.Created = DateTime.UtcNow;
                _dataSet.Add(item);

                // Persiste contexto(dados) no banco
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        /// <summary>
        /// Busca um registro pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<T> Select(Guid id)
        {
            try
            {
                // Busca  e retorn os dados do banco
                return  await _dataSet.SingleOrDefaultAsync(d =>
                        d.Id.Equals(id) &&
                        !d.Deleted
                    );

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Busca a lista de todos os registros do banco
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<T>> Select()
        {
            try
            {
                // Busca  e retorn os dados do banco
                return await _dataSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Atualiza um registro no banco de dados
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<T> Update(T item)
        {
            try
            {
                // Busca o registro na base
                var data = await _dataSet.SingleOrDefaultAsync(d => 
                        d.Id.Equals(item.Id) &&
                        !d.Deleted
                    );

                // Verifica se encontrou registo
                if (data == null)
                    return null;

                item.Updated = DateTime.UtcNow;
                item.Created = data.Created;

                // Atualizo os valores do contexo
                _context.Entry(data).CurrentValues.SetValues(item);

                // Persiste contexto(dados) em banco
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}
