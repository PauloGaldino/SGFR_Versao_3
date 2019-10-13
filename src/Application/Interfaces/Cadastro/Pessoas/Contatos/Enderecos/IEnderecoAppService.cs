using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using System.Collections.Generic;

namespace Application.Interfaces.Cadastro.Pessoas.Contatos.Enderecos
{
    public interface IEnderecoAppService : IAppServiceBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPeloCep(string cep);
    }
}
