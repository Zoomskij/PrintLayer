using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrintLayer.Models
{
    public abstract class BaseEntity
    {
        private DateTime _addedDate;
        private DateTime _modifiedDate;
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate
        {
            get => DateTime.SpecifyKind(_addedDate, DateTimeKind.Utc);
            private set => _addedDate = value;
        }
        public DateTime ModifiedDate
        {
            get => DateTime.SpecifyKind(_modifiedDate, DateTimeKind.Utc);
            set => _modifiedDate = value;
        }
    }
}
