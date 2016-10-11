using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<PessoaDomain>, IPessoaRepository
    {
    }
}
