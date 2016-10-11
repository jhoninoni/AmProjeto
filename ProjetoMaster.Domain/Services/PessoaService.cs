using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Domain.Interfaces.Services;
using ProjetoMaster.Domain.Interfaces.Services;

namespace ProjetoMaster.Domain.Services
{
    public class ProdutoService : ServiceBase<PessoaDomain>, IPessoaService
    {
        private readonly IPessoaRepository _produtoRepository;

        public ProdutoService(IPessoaRepository produtoRepository)
            :base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
