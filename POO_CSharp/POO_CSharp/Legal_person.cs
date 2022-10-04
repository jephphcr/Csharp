using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    public class Legal_person : Person
    {
        public Legal_person (string name)
        {
            this.Name = name;
            this.Name = this.CustomizedName();
        }

        public string Cnpj { get; set; }

        public string NomeFantasia { get; set; }


        public static List<Legal_person> Base = new List<Legal_person>();

        public static List<Legal_person> FindbyName(string name)
        {
            var newList = new List<Legal_person>();
                foreach(var instance in Legal_person.Base)
            {
                if (instance.Name.ToLower().Contains(name.ToLower()))
                {
                    newList.Add(instance);
                }
            }
                return newList;
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}
