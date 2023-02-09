using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.Persistence.Repositories
{

    public interface IFindStrategy<T>
    {
        List<T> find(NpgsqlConnection connection);
    }
}
