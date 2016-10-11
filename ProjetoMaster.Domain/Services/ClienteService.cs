using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Domain.Interfaces.Repositories;
using ProjetoMaster.Domain.Interfaces.Services;

namespace ProjetoMaster.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        protected readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            :base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
