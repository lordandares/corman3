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
    
    public partial class usuario_grupo_usuario
    {
        public int cod_usuario_grupo_usuario { get; set; }
        public string cod_usuario { get; set; }
        public Nullable<int> cod_grupo_usuario { get; set; }
    
        public virtual grupo_usuario grupo_usuario { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
