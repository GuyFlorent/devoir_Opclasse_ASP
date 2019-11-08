using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace devoir_Op.Models
{
    public class Empruntes
    {
        public List<Emprunte> empruntes()
        {
            return new List<Emprunte>
            {
                new Emprunte{ client ="Junior", Titre ="Le survivant"},
                new Emprunte{ client ="Romi", Titre ="Le vol du futur"},
                 new Emprunte{ client ="Romi", Titre ="Le bandit"}
            };
        }
    }
}