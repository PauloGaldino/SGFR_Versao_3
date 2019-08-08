using AutoMapper;
using Domain.Entities.Cadastro;
using Domain.Entities.Producao;
using SGFR_Web.ViewModels;

namespace SGFR_Web.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
