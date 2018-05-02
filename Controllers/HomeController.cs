using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using codicioso.Models;



namespace codicioso.Controllers

{

    public class HomeController : Controller

    {

        public IActionResult Index()

        {

            return View();

        }

        public IActionResult Cambio(string dinero){
            int cinco=5;
            int resultado1=0,resultado2=0,resultado3=0,resultado4=0,resultado5=0;
            decimal cambio=decimal.Parse(dinero, CultureInfo.InvariantCulture.NumberFormat);
            decimal resultador1=cambio/cinco;
            if(resultador1>=1){
             resultado1=(int)resultador1;
            cambio=(decimal) cambio-resultado1*5;
            }
            decimal resultador2=cambio/1;
            if(resultador2>=1){
            resultado2=(int)resultador2;
            cambio=(decimal) cambio-resultado2*1;
            }
            decimal resultador3=cambio/0.5m;
            if(resultador3>=1){
            resultado3=(int)resultador3;
            cambio=(decimal) cambio-resultado3*0.5m;
            }
            decimal resultador4=cambio/0.1m;
            if(resultador4>=1){
            resultado4=(int)resultador4;
            cambio=(decimal) cambio-resultado4*0.1m;
            }
            decimal resultador5=cambio/0.01m;
            if(resultador5>=1){
            resultado5=(int)resultador5;
            cambio=(decimal) cambio-resultado5*0.01m;
            }
            int total=resultado1+resultado2+resultado3+resultado4+resultado5;
            ViewBag.ok0=total;
            ViewBag.ok=resultado1;
            ViewBag.ok2=resultado2;
            ViewBag.ok3=resultado3;
            ViewBag.ok4=resultado4;
            ViewBag.ok5=resultado5;
            return View();

        }




    }

}