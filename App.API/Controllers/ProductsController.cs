using App.Core.DTOs;
using App.Core.Entities;
using App.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Product> _service;

        public ProductsController(IMapper mapper, IGenericService<Product> service)
        {
            _mapper=mapper;
            _service=service;
        }
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
        }
    }
}
