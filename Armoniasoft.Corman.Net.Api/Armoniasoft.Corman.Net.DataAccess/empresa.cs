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
    
    public partial class empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empresa()
        {
            this.documentoes = new HashSet<documento>();
            this.documentoes1 = new HashSet<documento>();
            this.empresa1 = new HashSet<empresa>();
            this.grupo_directorio = new HashSet<grupo_directorio>();
        }
    
        public int cod_empresa { get; set; }
        public Nullable<int> cod_matriz { get; set; }
        public Nullable<int> cod_seccion { get; set; }
        public string desc_empresa { get; set; }
        public string sigla { get; set; }
        public string sucursal { get; set; }
        public Nullable<int> cod_tipo_empresa { get; set; }
        public string direccion { get; set; }
        public int cod_pais { get; set; }
        public int cod_ciudad { get; set; }
        public Nullable<int> cod_zona { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string fax { get; set; }
        public string e_mail { get; set; }
        public string weburl { get; set; }
        public int cod_rubro { get; set; }
        public string comentarios { get; set; }
        public Nullable<System.DateTime> fecha_de_alta { get; set; }
        public string ruc { get; set; }
        public string casilla { get; set; }
        public string discado_dir_emp { get; set; }
        public string usuario_reg { get; set; }
        public Nullable<System.DateTime> fecha_reg { get; set; }
        public string usuario_mod { get; set; }
        public Nullable<System.DateTime> fecha_mod { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documento> documentoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documento> documentoes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empresa> empresa1 { get; set; }
        public virtual empresa empresa2 { get; set; }
        public virtual tipo_empresa tipo_empresa { get; set; }
        public virtual zona zona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<grupo_directorio> grupo_directorio { get; set; }
    }
}
