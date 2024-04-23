using Projeto_Triade.Abstraction.Interfaces.Repository;
using Projeto_Triade.Model.ValueObjects;

namespace Projeto_Triade.Infrastructure.Repository
{
    public class RelatorioRepository:IRelatorioRepository
    {
        private string _connectionString;

        public RelatorioRepository(ConfigurationVO config)
        {
            _connectionString = config.ConnectionString;
        }
    }
}
