using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_postgresql.Entities
{
    public class EntityB
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EntityB() { }
        public EntityB(string name)
        {
            this.Name = name;
        }
        public EntityB(int id)
        {
            this.Id = id;
        }

        public EntityB(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }



        //public System.Int32 Id { get; set; }
        //public string Name { get; set; }

        //public EntityB() { }
        //public EntityB(string name)
        //{
        //    this.Name = name;
        //}
        //public EntityB(int id)
        //{
        //    this.Id = System.Int32.Parse(id.ToString());
        //}

        //public EntityB(int id, string name)
        //{
        //    if(id.GetType() == typeof(System.Int32))
        //    {
        //        this.Id = id;   
        //    } else
        //    {
        //        this.Id = System.Int32.Parse(id.ToString());
        //    }

        //    this.Name = name;
        //}
    }
}
