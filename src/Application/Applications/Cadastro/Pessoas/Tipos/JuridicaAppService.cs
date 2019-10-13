using System.Collections.Generic;
using Application.Interfaces.Cadastro.Pessoas.Tipos;
using Domain.Entities.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos;
using Domain.Services;

namespace Application.Applications.Cadastro.Pessoas.Tipos
{
    public class JuridicaAppService : ServiceBase<Juridica>, IJuridicaAppService
    {
        private readonly IJuridicaRepository _juridicaRepository;
        public JuridicaAppService(IJuridicaRepository juridicaRepository): base(juridicaRepository)
        {
            _juridicaRepository = juridicaRepository;
        }

        public IEnumerable<Juridica> BuscarPeloCnpj(string cnpj)
        {
            return _juridicaRepository.BuscarPelCnpj(cnpj);
        }
    }
}
