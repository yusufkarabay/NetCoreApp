using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;

    }
}
