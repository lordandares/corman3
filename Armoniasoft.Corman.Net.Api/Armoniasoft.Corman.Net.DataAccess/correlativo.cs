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
    
    public partial class correlativo
    {
        public int cod_correlativos { get; set; }
        public int cod_tipo_documento { get; set; }
        public Nullable<int> cod_seccion { get; set; }
        public string Alfanumerico { get; set; }
        public Nullable<int> cantidad_meses { get; set; }
        public Nullable<int> num_max { get; set; }
        public Nullable<System.DateTime> fecha_max { get; set; }
        public int num_ini { get; set; }
        public Nullable<int> num_inicio { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual seccion seccion { get; set; }
        public virtual tipo_documento tipo_documento { get; set; }
    }
}
