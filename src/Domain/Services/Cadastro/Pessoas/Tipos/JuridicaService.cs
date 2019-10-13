using System.Collections.Generic;
using Domain.Entities.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Services.Cadastro.Pessoas.Tipos;

namespace Domain.Services.Cadastro.Pessoas.Tipos
{
    public class JuridicaService : ServiceBase<Juridica>, IJuridicaService
    {
        private readonly IJuridicaRepository _juridicaRepository;
        public JuridicaService(IJuridicaRepository juridicaRepository): base(juridicaRepository)
        {
            _juridicaRepository = juridicaRepository;
        }

        public IEnumerable<Juridica> ObterJuridica(string cnpj)
        {
            return _juridicaRepository.BuscarPelCnpj(cnpj);
        }

    }
}
