using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMaster.Application.Interfaces;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Domain.Interfaces.Services;
using ProjetoMaster.Domain.Interfaces.Services;

namespace ProjetoMaster.Application.Entities
{
    public class PessoaAppService : AppServiceBase<PessoaDomain>, IPessoaAppService
    {
        private readonly IPessoaService _servicePessoa;

        public PessoaAppService(IPessoaService pessoaService)
            : base(pessoaService)
        {
            _servicePessoa = pessoaService;
        }
    }
}
