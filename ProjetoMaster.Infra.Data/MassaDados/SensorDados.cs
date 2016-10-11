using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class SensorDados
    {
        public SensorDados()
        {
            var repositorySensor = new SensorRepository();

            try
            {
                repositorySensor.Add(new SensorDomain() 
                {
                   CodigoFabrica = 1,
                   NomeSensor = "Pulseira Xiaomi"
                });

                repositorySensor.Add(new SensorDomain()
                {
                    CodigoFabrica = 2,
                    NomeSensor = "Cartão RFID"
                });

                repositorySensor.Add(new SensorDomain()
                {
                    CodigoFabrica = 3,
                    NomeSensor = "Chaveiro RFID"
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositorySensor.Dispose();
            }
        }
    }
}
