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
    
    public partial class grupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public grupo()
        {
            this.documentoes = new HashSet<documento>();
            this.grupo_directorio = new HashSet<grupo_directorio>();
        }
    
        public int cod_grupo { get; set; }
        public string cod_usuario { get; set; }
        public string desc_grupo { get; set; }
        public int cod_tipo_dest { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documento> documentoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<grupo_directorio> grupo_directorio { get; set; }
        public virtual tipo_dest tipo_dest { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
