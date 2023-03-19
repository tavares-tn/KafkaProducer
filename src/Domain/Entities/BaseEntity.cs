using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BaseEntity
    {
        /// <summary>
        /// Identificador único
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Delete lógico
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Data de alteração do registro
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Data de criação do registro
        /// </summary>
        public DateTime? Created
        {
            get { return _created; }
            set { _created = (value == null ? DateTime.UtcNow : value); }
        }

        private DateTime? _created;
    }
}
