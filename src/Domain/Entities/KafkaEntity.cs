using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class KafkaEntity : BaseEntity
    {


        /// <summary>
        /// Nome
        /// </summary>
        [StringLength(10, MinimumLength = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Idade
        /// </summary>
        [Required(ErrorMessage = "Campo obrigatório")]
        public long Age { get; set; }
    }
}
