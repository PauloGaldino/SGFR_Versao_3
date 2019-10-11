using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Enderecos
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        IEnumerable<Endereco> ObterEndereco(IEnumerable<Endereco> enderecos);
    }
}
