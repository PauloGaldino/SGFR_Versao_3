using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPelóCep(string cep);
    }
}
