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
    
    public partial class tipo_datos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_datos()
        {
            this.documentoes = new HashSet<documento>();
            this.documentoes1 = new HashSet<documento>();
        }
    
        public int cod_tipo_datos { get; set; }
        public string desc_tipo_datos { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documento> documentoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documento> documentoes1 { get; set; }
    }
}
