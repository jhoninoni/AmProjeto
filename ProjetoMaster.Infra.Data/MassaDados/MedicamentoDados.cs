using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class MedicamentoDados
    {
        public MedicamentoDados()
        {
            var repositoryMedicamento = new MedicamentoRepository();
            var repositoryFuncionario = new FuncionarioRepository().GetAll().FirstOrDefault();

            try
            {
                repositoryMedicamento.Add(new MedicamentoDomain()
                {
                    FuncionarioId = repositoryFuncionario.FuncionarioDomainId,
                    Nome = "Dorflex",
                    QtdDose = 1,
                    DataMedicado = DateTime.Now
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryMedicamento.Dispose();
            }
        }
    }
}
