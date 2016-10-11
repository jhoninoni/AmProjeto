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
    public class UsuarioService : ServiceBase<UsuarioDomain>,IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
            :base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
