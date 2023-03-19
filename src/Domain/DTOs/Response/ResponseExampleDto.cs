using System;

namespace Domain.DTOs.Response
{
    public class ResponseExampleDto
    {
        /// <summary>
        /// Nome
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Idade
        /// </summary>
        public long Age { get; set; }

        /// <summary>
        /// Identificador único
        /// </summary>
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
        public DateTime? Created { get; set; }
    }
}
