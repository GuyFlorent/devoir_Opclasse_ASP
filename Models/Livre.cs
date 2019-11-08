using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace devoir_Op.Models
{
    public class Livre
    {
        public int Id_Livre { get; set; }
        public string Titre { get; set; }
        public string Date_parution { get; set; }
       // public Auteur auteur { get; set; }
       public string auteur { get; set; }
    }
}