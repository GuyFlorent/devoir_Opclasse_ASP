using devoir_Op.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace devoir_Op.Controllers
{
    public class RechercherController : Controller
    {
        // GET: Rechercher
        public ActionResult Livre(string id)
        {
            Livres livres = new Livres();
            Auteurs auteurs = new Auteurs();
            if (id != null)
            {
                var rechercheLivres = livres.listeLivre().Where(f => f.auteur.Contains(id.ToLower()) || f.Titre.Contains(id.ToLower())).ToList();
                if (rechercheLivres != null)
                {
                    ViewData["Livres_Recherche"] = rechercheLivres;
                    return View("Livre");
                }
                else
                {
                    return View("PasTrouver");
                }
            }
            else return View("PasTrouver");
        }
    }
}