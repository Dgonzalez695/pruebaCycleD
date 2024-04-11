using APISCycle.Aplication.Dtos.Productos;
using APISCycle.Domain.Entities;
using AutoMapper;

namespace APISCycle.Aplication.Mapping
{
    public class AutoMapping : Profile
    {

        public AutoMapping()
        {

            CreateMap<ProductoDto, Producto>().ReverseMap();
        }
    }
}
