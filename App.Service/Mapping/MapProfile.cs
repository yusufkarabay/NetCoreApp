using App.Core.DTOs;
using App.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //reversemap iki yönlü dönüşüm sağlar. yazmasak 1.den 2.ye dönüşüm sağlar
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();


        }
    }
}
