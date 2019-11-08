using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace devoir_Op.Models
{
    public class Clients
    {
        public List<Client> clients()
        {
            return new List<Client>
            {
                new Client{ nom = "Junior", email = "jun@yahoo.fr" , Id_client = 1},
                new Client{ nom = "Romi", email = "Romi@yahoo.fr" , Id_client = 2},
            };
        }
    }
}