using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Response
{
    public class ResponseExampleModel
    {
        private string _name;
        private long _age;
        private Guid _id;
        private bool _deleted;
        private DateTime? _created;
        private DateTime? _updated;

        /// <summary>
        /// Nome
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Idade
        /// </summary>
        public long Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// Identificador único
        /// </summary>
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Delete lógico
        /// </summary>
        public bool Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        /// <summary>
        /// Data de alteração do registro
        /// </summary>
        public DateTime? Updated
        {
            get { return _updated; }
            set { _updated = value; }
        }

        /// <summary>
        /// Data de criação do registro
        /// </summary>
        public DateTime? Created
        {
            get { return _created; }
            set { _created = value; }
        }
    }
}
