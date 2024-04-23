using Projeto_Triade.Abstraction.Interfaces.Repository;
using Projeto_Triade.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Triade.Infrastructure.Repository
{
    public class RequisicaoRepository : IRequisicaoRepository
    {
        private string _connectionString;

        public RequisicaoRepository(ConfigurationVO config)
        {
            _connectionString = config.ConnectionString;
        }
    }
}
