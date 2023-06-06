using Confluent.Kafka;
using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using System;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class KafkaRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        protected readonly Config _config;
        protected readonly string _topic;



        public KafkaRepository(MyContext contex)
        {
            _context = contex;
            _config = new ProducerConfig { BootstrapServers = "127.0.0.1:9092" };
            _topic = "testetopico";
        }


        public async Task<bool> Insert(string mensagem)
        {
            var p = new ProducerBuilder<Null, string>(_config).Build();
            {
                try
                {
                    if (String.IsNullOrEmpty(mensagem))
                        mensagem = "mensagem nula";

                    await p.ProduceAsync(_topic, new Message<Null, string> { Value = mensagem });

                    return true;
                }
                catch (ProduceException<Null, string> erro)
                {
                    throw erro;
                }
            }
        }

    }
}
