using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace devoir_Op.Models
{
    public class Livres
    {
        public List<Livre> listeLivre()
        {
            return new List<Livre>
            {
                new Livre{ Id_Livre =1, Date_parution ="12/2/1985", Titre="Le survivant", auteur = "jean" },
                new Livre{ Id_Livre =2, Date_parution ="12/10/1999", Titre="Le vie du foot",auteur =  "Paul"},
                new Livre{ Id_Livre =3, Date_parution ="26/09/2015", Titre="Le client de doranco",auteur =  "remi" },
                new Livre{ Id_Livre =4, Date_parution ="3/10/2006", Titre="Le vol du futur", auteur =  "Paul" },
                new Livre{ Id_Livre =5, Date_parution ="12/10/1999", Titre="Le bandit", auteur =  "Paul" }
            };
        }
    }
}