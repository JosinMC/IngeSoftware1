//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_ASPNET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TELEFONO
    {
        public string cedulaCliente { get; set; }
        public string numero { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
    }
}
