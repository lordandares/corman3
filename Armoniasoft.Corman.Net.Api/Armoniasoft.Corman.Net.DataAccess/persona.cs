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
    
    public partial class persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public persona()
        {
            this.documentoes = new HashSet<documento>();
            this.documentoes1 = new HashSet<documento>();
            this.grupo_directorio = new HashSet<grupo_directorio>();
            this.notificacions = new HashSet<notificacion>();
            this.notificacions1 = new HashSet<notificacion>();
            this.notificacion_baja = new HashSet<notificacion_baja>();
            this.persona_firma = new HashSet<persona_firma>();
            this.usuarios = new HashSet<usuario>();
        }
    
        public int cod_persona { get; set; }
        public Nullable<int> cod_empresa { get; set; }
        public Nullable<int> cod_seccion { get; set; }
        public string nombres_persona { get; set; }
        public string apellidos_persona { get; set; }
        public string telefono_dom_persona { get; set; }
        public string celular_persona { get; set; }
        public string direccion_persona { get; set; }
        public Nullable<int> cod_pais { get; set; }
        public Nullable<int> cod_ciudad { get; set; }
        public Nullable<int> cod_zona { get; set; }
        public string telefono_ofi_persona { get; set; }
        public Nullable<int> interno_persona { get; set; }
        public string telefono_aux_persona { get; set; }
        public string fax_persona { get; set; }
        public string email_persona { get; set; }
        public string email2_persona { get; set; }
        public string comentarios { get; set; }
        public Nullable<System.DateTime> fecha_de_alta { get; set; }
        public string ci_persona { get; set; }
        public string casilla_persona { get; set; }
        public string discado_dir_per { get; set; }
        public string cod_genero { get; set; }
        public string prefijo_persona { get; set; }
        public string cod_postal_persona { get; set; }
        public Nullable<int> cod_cargo { get; set; }
        public Nullable<int> seccion_persona { get; set; }
        public bool activo { get; set; }
        public string usuario_reg { get; set; }
        public Nullable<System.DateTime> fecha_reg { get; set; }
        public string usuario_mod { get; set; }
        public Nullable<System.DateTime> fecha_mod { get; set; }
        public Nullable<int> cod_referencia { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documento> documentoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documento> documentoes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<grupo_directorio> grupo_directorio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notificacion> notificacions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notificacion> notificacions1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notificacion_baja> notificacion_baja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<persona_firma> persona_firma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}
