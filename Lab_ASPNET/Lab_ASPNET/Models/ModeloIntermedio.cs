using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ASPNET.Models
{
   public class ModeloIntermedio
    {
        public CLIENTE modeloCliente { get; set; }
        public CUENTA modeloCuenta1 { get; set; }
        public CUENTA modeloCuenta2 { get; set; }
        public CUENTA modeloCuenta3 { get; set; }


        public TELEFONO modeloTelefono1 { get; set; }
        public TELEFONO modeloTelefono2 { get; set; }
        public TELEFONO modeloTelefono3 { get; set; }


        public List<CLIENTE> listaClientes = new List<CLIENTE>();

        public List<CUENTA> listaCuentas = new List<CUENTA>();

        public List<TELEFONO> listaTelefonos = new List<TELEFONO>();

    }
}
