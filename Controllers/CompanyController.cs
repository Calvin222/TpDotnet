using Company.Data;
using Company.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _BDD;

        public CompanyController(ApplicationDbContext BDD)
        {
            _BDD = BDD;
        }
        public IActionResult Lister()
        {
            IEnumerable<T_Company> listeObjets = _BDD.T_Company;
            return View(listeObjets);
        }

        public IActionResult Ajouter()
        {
            return View();
        }

        public IActionResult Tester()
        {
            List<ListeCompanys> maListeCompanys = new List<ListeCompanys>();
            maListeCompanys.Add(new ListeCompanys()
            {
                Id = 1,
                NomCompany = "Company A"
            });
            maListeCompanys.Add(new ListeCompanys()
            {
                Id = 2,
                NomCompany = "Company B"
            });
            return View(maListeCompanys);
        }
    }
}
