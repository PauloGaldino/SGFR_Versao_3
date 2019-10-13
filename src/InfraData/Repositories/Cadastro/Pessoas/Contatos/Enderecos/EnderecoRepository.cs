using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos;

namespace InfraData.Repositories.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public IEnumerable<Endereco> BuscarPelóCep(string cep)
        {
            return Db.Enderecos.Where(e => e.CEP == cep);
        }
    }
}
