using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    public class Physical : Person
    {
        public Physical(string name)
        {
            this.Name = name;
            this.Name = this.CustomizedName();
        }

        public override void Save()
        {
            Physical.MemoryBankPhysicalPerson.Add(this);
        }
        
        public string Gender { get; set; }

        /// <summary>
        /// Uses the method CustomizedName() of the inherited class
        /// </summary>
        /// <returns></returns>
        public override string CustomizedName()
        {
            return $"Virtual/Override test - {this.Name}";
        }
        /// <summary>
        /// Method with the same name of virtual method in Person class
        /// </summary>
        /// <param name="nick"></param>
        /// <returns></returns>
        public string CustomizedName(string nick)
        {
            return $"{base.CustomizedName()} - Nickname - {nick}";
        }

        public static List<Physical> MemoryBankPhysicalPerson = new List<Physical>();

        public static List<Physical> All()
        {
            return Physical.MemoryBankPhysicalPerson;
        }
        
        public static void Save(Physical obj)
        {
            Physical.MemoryBankPhysicalPerson.Add(obj);
        }

        public static List<Physical> Find(string name)
        {
            var newList = new List<Physical>();
            foreach(var instan in Physical.MemoryBankPhysicalPerson)
            {
                if (instan.Name.ToLower().Contains(name.ToLower()))
                {
                    newList.Add(instan);
                }
            }
            return newList;
        }


        public override void Find()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
