using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_csharp_postgresql
{
    public interface IUnitOfWork
    {
        void connect();
        void disconnect();
    }
}
