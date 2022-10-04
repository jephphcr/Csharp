using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    public abstract class Person: IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Cpf {get; set; }
        
        public virtual string CustomizedName()
        {
            return $"{this.Name} - POO Trainning";
        }

        public abstract void Save();
        public List<IPerson> Find()
        {
            return null;
        }
        public void Delete()
        {
            Service.Save(this);
        }

        
    }
}
