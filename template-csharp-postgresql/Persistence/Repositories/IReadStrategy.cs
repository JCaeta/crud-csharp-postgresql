using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Models;

namespace template_csharp_postgresql.Persistence.Repositories
{

    public interface IReadStrategy<T>
    {
        List<T> read(NpgsqlConnection connection);
    }
}
