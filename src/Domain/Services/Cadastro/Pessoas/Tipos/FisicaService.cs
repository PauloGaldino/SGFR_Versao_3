using System.Collections.Generic;
using Domain.Entities.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Services.Cadastro.Pessoas.Tipos;

namespace Domain.Services.Cadastro.Pessoas.Tipos
{
    public class FisicaService : ServiceBase<Fisica>, IFisicaService
    {
        private readonly IFisicaRepository _fisicaRepository;
        public FisicaService(IFisicaRepository fisicaRepository) : base(fisicaRepository)
        {
            _fisicaRepository = fisicaRepository;
            
        }
        public IEnumerable<Fisica> ObterFisica(string cpf)
        {
            return _fisicaRepository.BuscarPeloCpf(cpf);
        }

       
    }
}
