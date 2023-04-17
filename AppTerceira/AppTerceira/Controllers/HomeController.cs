using AppTerceira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTerceira.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Fisica pf = new Fisica()
            {
                Id = 2,
                Nome = "Roberta",
                Sexo = 'F',
                CPF = 12345678911,
                RG = 12345678,
                Dig_RG = '9'
            };

            return View(pf);
        }

        public ActionResult About()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 12;
            pessoa.Nome = "Enildo";
            pessoa.Sexo = 'M';
            return View(pessoa);
        }

        public ActionResult Contact()
        {
            Juridica pj = new Juridica();

            pj.Id = 1001;
            pj.Nome = "Fabrica de Gênios";
            pj.Cnpj = 123456789123412;
            pj.IE = 123456789;

            return View(pj);
        }
    }
}