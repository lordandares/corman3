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
    
    public partial class persona_firma
    {
        public int cod_persona_firma { get; set; }
        public int cod_persona { get; set; }
        public int cod_seccion { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual persona persona { get; set; }
        public virtual seccion seccion { get; set; }
    }
}
