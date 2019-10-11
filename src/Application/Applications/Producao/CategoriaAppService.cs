using Application.Interfaces.Producao;
using Domain.Entities.Producao;
using Domain.Interfaces.Services.Producao;

namespace Application.Applications.Producao
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaAppService(ICategoriaService categoriaService) : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }
    }
}
