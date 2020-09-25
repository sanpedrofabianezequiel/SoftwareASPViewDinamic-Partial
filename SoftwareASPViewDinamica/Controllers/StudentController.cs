using SoftwareASPViewDinamica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareASPViewDinamica.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            //Armo una lista de estudiantes
            //SIN PEGARLE  a la BD en este caso LUEGO SI
            //Lo estamos armando en MEMORIA
            List<Student> lista = new List<Student>() { 
                new Student
                {
                    StudentId=1,Name="Juan",Gender="Male",City="La Plata",Address="Brasil Ramos Mejia"
                }

            };


            //Le enviamos a la vista la Lista,podria haber sido un ToList();
           //return ("Index",lista)
            return View(lista);
        }

        //--------------

        //GET
        public ActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]//Recibe un MODELO "un student"
        public ActionResult Create(Student newStudent)
        {
            //Aca iria el codigo e acceso  A DATOS DAC
            Student nuevo = newStudent;
            
            //(Vista=Create,Modelo)
            //(cuando creo la vista tiene que tener este nombre,envio la data)
            //UTILIZAMOS UNA PLANTILLA DETALLES EN LA VISTA para hacerlo mas optimo

            return View("Detalle",nuevo);
        }


        
    }
}