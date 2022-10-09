using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void Save()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Nome não pode ser vazio");
            }

            if (this.Id > 0)
            {
                new Database.Person().Update(Id, Name, CPF, Phone, Email);
                return;
            }

            this.Id = new Database.Person().Save(this.Name, this.CPF, this.Phone, this.Email);

        }

        public static List<Person> List()
        {
            return List(string.Empty);
        }

        public static List<Person> List(string name)
        {
            var person = new List<Person>();
            DataTable data = new Database.Person().List(name);

            for (var i = 0; i < data.Rows.Count; i++)
            {
                person.Add(new Person
                {
                    Id = Convert.ToInt32(data.Rows[i]["id"]),
                    CPF = data.Rows[i]["cpf"].ToString(),
                    Name = data.Rows[i]["name"].ToString(),
                    Phone = data.Rows[i]["phone"].ToString(),
                    Email = data.Rows[i]["email"].ToString(),

                });

            }

            return person;
        }

        public void Excluir(int id)
        {
            new Database.Person().Excluir(id);
        }
    }
}
