using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.DTOs
{
    public class ProductUpdateDto
    {
        //ben güncelleme işlemi yaparsam eğer productdto kullarsam base entityden gelen created date görünecektir. görünmemesi için yalnızca
        //update işleminde kullanabileceğimiz dto oluşturdum base entityden türetmedim

        //her entitiynin crud işlemlerinde endpointlerde birer response dtosu oluşturmak yanlış bir yaklaşım. entity sayıları arttıkça kod tekrarına dönecektir
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
