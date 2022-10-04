using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    public class Feline : IAnimal
    {
        public string Name { get; set; }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                throw new AnimalException("The name can't be empty");
            } throw new Exception();
        }
    }
}
