using AutoMapper;
using Domain.Entities.Cadastro.Pessoas.Clientes;
using Domain.Entities.Producao;
using Domain.Entities.Vendas;
using SGFR_Web_v02.ViewModels;
using SGFR_Web_v02.ViewModels.Vendas;

namespace SGFR_Web_v02.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ImpostoVIewModel, Imposto>();
            CreateMap<CategoriaViewModelexc, Categoria>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
