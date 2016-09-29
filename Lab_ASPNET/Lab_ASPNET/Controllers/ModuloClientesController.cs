using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_ASPNET.Models;
using System.Net;

namespace Lab_ASPNET.Controllers
{
    public class ModuloClientesController : Controller
    {
        BD_B43939Entities baseDatos = new BD_B43939Entities();
        // GET: ModuloClientes
        public ActionResult Index()
        {
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.listaClientes = baseDatos.CLIENTE.ToList();
            modelo.listaTelefonos = baseDatos.TELEFONO.ToList();
            modelo.listaCuentas = baseDatos.CUENTA.ToList();
            return View(modelo);
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloIntermedio modelo)
        {
            if (ModelState.IsValid)
            {
                baseDatos.CLIENTE.Add(modelo.modeloCliente);
                baseDatos.SaveChanges();
                if (modelo.modeloTelefono1.numero != null)
                {
                    modelo.modeloTelefono1.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.TELEFONO.Add(modelo.modeloTelefono1);
                }
                if (modelo.modeloTelefono2.numero != null)
                {
                    modelo.modeloTelefono2.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.TELEFONO.Add(modelo.modeloTelefono2);
                }
                if (modelo.modeloCuenta1.numero != null)
                {
                    modelo.modeloCuenta1.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.CUENTA.Add(modelo.modeloCuenta1);
                }
                if (modelo.modeloCuenta2.numero != null)
                {
                    modelo.modeloCuenta2.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.CUENTA.Add(modelo.modeloCuenta2);
                }
                if (modelo.modeloCuenta3.numero != null)
                {
                    modelo.modeloCuenta3.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.CUENTA.Add(modelo.modeloCuenta3);
                }
                baseDatos.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE c = baseDatos.CLIENTE.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.modeloCliente = c;
            List<TELEFONO> telefonos = new List<TELEFONO>();
            telefonos = baseDatos.TELEFONO.Where(a => a.cedulaCliente == c.cedula).ToList();
            int countt = telefonos.Count();
            if (countt == 1)
            {
                modelo.modeloTelefono1 = telefonos.ElementAt(0);
            }
            else if (countt == 2)
            {
                modelo.modeloTelefono2 = telefonos.ElementAt(1);
            }

            List<CUENTA> cuentas = new List<CUENTA>();
            cuentas = baseDatos.CUENTA.Where(a => a.cedulaCliente == c.cedula).ToList();
            int countc = cuentas.Count();
            if (countc == 1)
            {
                modelo.modeloCuenta1 = cuentas.ElementAt(0);
            }
            else if (countc == 2)
            {
                modelo.modeloCuenta2 = cuentas.ElementAt(1);
            }
            else if (countc == 3)
            {
                modelo.modeloCuenta3 = cuentas.ElementAt(2);
            }
            return View(modelo);
        }
    }
}