using AutoMapper;
using Domain.Entities.Cadastro;
using Domain.Entities.Producao;
using Domain.Entities.Vendas;
using SGFR_Web.ViewModels;
using SGFR_Web.ViewModels.Vendas;

namespace SGFR_Web.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ImpostoVIewModel, Imposto>();
            CreateMap<CategoriaViewModel, Categoria>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
