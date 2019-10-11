using Domain.Entities.Producao;
using Domain.Interfaces.Repositories.Producao;
using Domain.Interfaces.Services.Producao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Producao
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository): base(categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
    }
}
