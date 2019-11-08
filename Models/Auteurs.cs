using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace devoir_Op.Models
{
    public class Auteurs
    {
        public List<Auteur> auteurs()
        {
            return new List<Auteur>
            {
                new Auteur{IdAuteur = 1, nom_auteur = "jean"},
                new Auteur{IdAuteur=2, nom_auteur = "remi"},
                new Auteur{IdAuteur=3, nom_auteur = "Paul"}
            };
        }
    }   }
