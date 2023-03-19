
using AutoMapper;
using Domain.DTOs;
using Domain.DTOs.Request;
using Domain.DTOs.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ExampleService : IExampleService
    {
        private IRepository<ExampleEntity> _repository;
        private readonly IMapper _mapper;

        public ExampleService(IRepository<ExampleEntity> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        /// <summary>
        /// Remove um registro (delete lógico)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }

        /// <summary>
        /// Retorna um registro pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ExampleDto> Get(Guid id)
        {
            var result =  await _repository.Select(id);

            return _mapper.Map<ExampleDto>(result);
        }

        /// <summary>
        /// Retorna todos os registros
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<ExampleDto>> GetAll()
        {
            var result =  await _repository.Select();

            return _mapper.Map<IEnumerable<ExampleDto>>(result);
        }

        /// <summary>
        /// Cria um registro
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ResponseExampleDto> Post(RequestExampleDto example)
        {
            var model = _mapper.Map<RequestExampleModel>(example);

            var entity = _mapper.Map<ExampleEntity>(model);

            var result = await _repository.Insert(entity);

            return _mapper.Map<ResponseExampleDto>(result);
        }

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ResponseExampleDto> Put(ExampleDto example)
        {
            var model = _mapper.Map<ExampleModel>(example);

            var entity = _mapper.Map<ExampleEntity>(model);

            var result = await _repository.Insert(entity);

            return _mapper.Map<ResponseExampleDto>(result);
        }
    }
}
