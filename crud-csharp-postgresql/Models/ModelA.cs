using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_csharp_postgresql.Models
{
    public class ModelA
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ModelB> ModelsB { get; set; }

        public ModelA()
        {
            this.ModelsB = new List<ModelB>();
        }

        public ModelA(string name)
        {
            this.Name = name;
            this.ModelsB = new List<ModelB>();
        }

        public ModelA(List<ModelB> modelsB)
        {
            this.ModelsB = modelsB;
        }

        public ModelA(string name, List<ModelB> modelsB)
        {
            this.Name = name;
            this.ModelsB = modelsB;
        }

        public ModelA(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.ModelsB = new List<ModelB>();
        }
        public ModelA(int id)
        {
            this.Id = id;
            this.ModelsB = new List<ModelB>();
        }
    }
}
