using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("ResponsavelAluno")]
    public class ResponsavelAlunoDomain
    {
        #region Propriedades

        public int ResponsavelAlunoDomainId { get; set; }
        public PessoaDomain Pessoa { get; set; }
        public int PessoaId { get; set; }
        public AlunoDomain Aluno { get; set; }
        public int AlunoId { get; set; }

        #endregion
    }
}
