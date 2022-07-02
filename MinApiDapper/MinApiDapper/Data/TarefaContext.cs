using System.Data;

namespace MinApiDapper.Data
{
    public class TarefaContext
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}
