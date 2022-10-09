using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Adresses
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public string PublicPlace { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public static List<Adresses> List()
        {
            return List(string.Empty);
        }

        public static List<Adresses> List(string id)
        {
            var person = new List<Adresses>();
            DataTable data = new Database.Adresses().List(id);

            for (var i = 0; i < data.Rows.Count; i++)
            {
                person.Add(new Adresses
                {
                    Id = Convert.ToInt32(data.Rows[i]["id"]),
                    PersonId = data.Rows[i]["person_id"].ToString(),
                    PublicPlace = data.Rows[i]["publicplace"].ToString(),
                    Number = data.Rows[i]["number"].ToString(),
                    District = data.Rows[i]["district"].ToString(),
                    City = data.Rows[i]["city"].ToString(),
                    State = data.Rows[i]["state"].ToString(),
                    

                });

            }

            return person;
        }

    }
}
