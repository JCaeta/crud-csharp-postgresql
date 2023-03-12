using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_csharp_postgresql.Models
{
    public class ModelB
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ModelB() { }
        public ModelB(string name)
        {
            this.Name = name;
        }
        public ModelB(int id)
        {
            this.Id = id;
        }

        public ModelB(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
