using APISCycle.Aplication.Dtos.Productos;
using APISCycle.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APISCycle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ProductoDto>> ObtenerProductos()
        {
            Producto producto = new Producto();
            ProductoDto productoDto = _mapper.Map<ProductoDto>(producto);
            return null;
        }

        [HttpGet]
        public async Task<ActionResult<ProductoDto>> ObtenerProducto(int id)
        {
            Producto producto = new Producto();
            ProductoDto productoDto = _mapper.Map<ProductoDto>(producto);
            return null;
        }


        [HttpPost]
        public async Task<ActionResult<Producto>> CrearProducto(ProductoDto productoDto)
        {

            Producto producto = _mapper.Map<Producto>(productoDto);
            return null;

        }



    }
}
