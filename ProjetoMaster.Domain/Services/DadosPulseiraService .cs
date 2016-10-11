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
    public class DadosPulseiraService  : ServiceBase<DadosSensorDomain>, IDadosSensorService
    {
        private readonly IDadosSensorRepository _dadosPulseira;

        public DadosPulseiraService(IDadosSensorRepository dadosPulseira)
            : base(dadosPulseira)
        {
            _dadosPulseira = dadosPulseira;
        }
    }
}
