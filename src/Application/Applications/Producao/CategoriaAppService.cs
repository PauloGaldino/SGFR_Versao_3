using Application.Interfaces.Producao;
using Domain.Entities.Producao;
using Domain.Interfaces.Services.Producao;

namespace Application.Applications.Producao
{
    public class CategoriaAppService : AppServiceBase<Categoria>, InterfaceCategoriaAppService
    {
        private readonly InterfaceCategoriaService _categoriaService;
        public CategoriaAppService(InterfaceCategoriaService categoriaService) : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }
    }
}
