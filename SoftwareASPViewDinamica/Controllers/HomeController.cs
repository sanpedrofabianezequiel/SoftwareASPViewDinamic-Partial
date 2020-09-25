using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareASPViewDinamica.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Definimos una ViewBag.MiNombre =" mensaje";

            ViewBag.miMensaje = "Welcome to Jungle";
            return View();
        }



        //GET
       public ActionResult Form()
        {
            //La vista se va a llamar como el metodo de accion
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Form( FormCollection formulario)
        {//Aca trabajamos con la FormCollection

            //Definimos valor para el HTML
            //El formulario recibe todos los elementos que fueron llenados
            //podemos usarlo por indice o nombre declarado
            var name = formulario[0].ToString();
            var address = formulario["Address"].ToString();
            var gender = formulario["Gender"].ToString();
            var isMarried = formulario["IsMarried"].ToString();
            var country = formulario["Country"].ToString();
            var password = formulario["Password"].ToString();

            //CODIGO DE DAC

            //Luego retornamos la vista
            //vista form
            return View();
        }
    }
}
