using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    public  class AnimalException: Exception
    {
        private string message;
        
        public AnimalException(string message)
        {
            this.message = message;
        }
        public override string ToString()
        {
            return this.message;
        }

        public override string Message => this.message;
    }
}
