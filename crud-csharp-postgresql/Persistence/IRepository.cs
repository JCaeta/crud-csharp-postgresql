using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_csharp_postgresql.Persistence
{
    public interface IRepository<T>
    {
        T create(T item);
        List<T> read(T filter);
        T readOne(T filter);

        bool update(T item);
        bool delete(T item);
    }
}
