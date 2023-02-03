using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace template_csharp_postgresql.Persistence.Repositories
{

    public interface IFindStrategy<T>
    {
        List<T> find(NpgsqlConnection connection, NpgsqlTransaction transaction);
    }
}
