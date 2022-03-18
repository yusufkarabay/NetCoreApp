using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entities
{
    public class ProductFeature:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Color { get; set; }
        public string? Height { get; set; }
        public string? Width { get; set; }

        public Guid ProductId { get; set; }

        public Product? Product { get; set; }
    }
}
