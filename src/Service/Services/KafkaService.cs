
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;

using System.Threading.Tasks;

namespace Service.Services
{
    public class KafkaService : IKafkaService
    {
        private IRepository<KafkaEntity> _repository;
        private readonly IMapper _mapper;

        public KafkaService(IRepository<KafkaEntity> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> Post(string evento)
        {
            return await _repository.Insert(evento);
        }
    }
}
