using devoir_Op.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace devoir_Op.Controllers
{
    public class AfficherController : Controller
    {
        // GET: Home

        public ActionResult Afficher()
        {
            Livres livres = new Livres();
            ViewData["livres"] = livres.listeLivre();
            return View();
        }
        public ActionResult Auteurs(int? id)
        {
            Auteurs auteurs = new Auteurs();
        
                ViewData["auteurs"] = auteurs.auteurs();
                return View("Auteurs");
           
        }

       public ActionResult Auteur(int? id)
        {
            Auteurs aut = new Auteurs();
            var t = (aut.auteurs().ToList()).FirstOrDefault(f => f.IdAuteur == id);
            if (t != null)
            {
                Livres livres = new Livres();
                ViewData["Livres_Auteur"] = livres.listeLivre().Where(f => f.auteur == t.nom_auteur).ToList();

                return View("Auteur");
            } else
            {
                return View("NonTrouver");
            }
        }

        public ActionResult Livre(int id)
        {
            Livres livres = new Livres();
            var livre_ID = (livres.listeLivre().ToList()).FirstOrDefault(f => f.Id_Livre == id);
            if (livre_ID != null)
            {


                Empruntes empruntes = new Empruntes();
                var emprunt = empruntes.empruntes().ToList().FirstOrDefault(f => f.Titre == livre_ID.Titre);
                if (emprunt != null)
                {
                    ViewData["livres_ID"] = livre_ID.Titre;
                    ViewData["livre_date"] = livre_ID.Date_parution;
                    ViewData["emprunteur"] = emprunt.client;
                    return View("Livre");

                }
                else
                {

                    ViewData["livres_ID"] = livre_ID.Titre;
                    ViewData["livre_date"] = livre_ID.Date_parution;
                    ViewData["emprunteur"] = "Livre non emprunter";
                    return View("Livre");
                }
            }
            else
            {
                return  View("NonTrouver"); 
            }
        }

       
        }
}