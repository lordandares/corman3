//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Armoniasoft.Corman.Net.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class filtro
    {
        public int cod_filtro { get; set; }
        public string cod_usuario { get; set; }
        public string desc_filtro { get; set; }
        public string nombre_tabla { get; set; }
        public string columnas { get; set; }
        public string columnas_o { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}
