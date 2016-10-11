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
    public class DadosSensorAppService : AppServiceBase<DadosSensorDomain>, IDadosSensorAppService
    {
        private readonly IDadosSensorService _serviceDadosPulseira;

        public DadosSensorAppService(IDadosSensorService dadosPulseira)
            : base(dadosPulseira)
        {
            _serviceDadosPulseira = dadosPulseira;
        }
    }
}
