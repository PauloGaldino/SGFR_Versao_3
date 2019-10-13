using System.Collections.Generic;
using Application.Interfaces.Cadastro.Pessoas.Tipos;
using Domain.Entities.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos;
using Domain.Services;

namespace Application.Applications.Cadastro.Pessoas.Tipos
{
    public class FisicaAppService : ServiceBase<Fisica>, IFisicaAppService
    {
        private readonly IFisicaRepository _fisicaRepository;
        public FisicaAppService(IFisicaRepository fisicaRepository) : base(fisicaRepository)
        {
            _fisicaRepository = fisicaRepository;
        }
        public IEnumerable<Fisica> BuscarPeloCpf(string cpf)
        {
            throw new System.NotImplementedException();
        }
    }
}
