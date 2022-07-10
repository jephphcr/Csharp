using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudXml
{
    public class Cliente

    {
        private int code;
        private string name;
        private string identity;
        private string cpf;
        private DateTime birthDate;

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Identity { get => identity; set => identity = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
    }
}
