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
    
    public partial class pa_ruta_documento_Result
    {
        public int cod_ruta { get; set; }
        public int cod_documento { get; set; }
        public System.DateTime fecha_ruta { get; set; }
        public Nullable<int> ordinal { get; set; }
        public System.Guid rowguid { get; set; }
        public int cod_notificacion { get; set; }
        public Nullable<int> cod_documento1 { get; set; }
        public Nullable<int> cod_ruta1 { get; set; }
        public int cod_tipo_notificacion { get; set; }
        public string usuario_reg { get; set; }
        public System.DateTime fecha_reg { get; set; }
        public int cod_prioridad { get; set; }
        public Nullable<int> persona_origen { get; set; }
        public Nullable<int> persona_destino { get; set; }
        public Nullable<int> cod_estado { get; set; }
        public string asunto { get; set; }
        public string notas_tarea { get; set; }
        public Nullable<int> cod_tipo_tarea { get; set; }
        public Nullable<System.DateTime> fecha_limite { get; set; }
        public Nullable<int> adjuntos { get; set; }
        public Nullable<bool> reasignable { get; set; }
        public Nullable<System.DateTime> fecha_alerta { get; set; }
        public Nullable<System.DateTime> fecha_concluido { get; set; }
        public Nullable<int> cod_alerta { get; set; }
        public Nullable<int> cod_ref { get; set; }
        public Nullable<System.DateTime> fecha_env { get; set; }
        public Nullable<System.DateTime> fecha_rec { get; set; }
        public Nullable<int> cod_tipo_copia { get; set; }
        public Nullable<int> reasignado_a { get; set; }
        public Nullable<int> reasignado_de { get; set; }
        public Nullable<int> cod_libro { get; set; }
        public Nullable<int> num_hoja_libro { get; set; }
        public Nullable<int> num_pos_libro { get; set; }
        public Nullable<int> num_destino { get; set; }
        public string usuario_mod { get; set; }
        public Nullable<System.DateTime> fecha_mod { get; set; }
        public Nullable<bool> alerta_plazo_vencido { get; set; }
        public Nullable<bool> alerta_tarea_concluida { get; set; }
        public Nullable<int> cod_alerta_pv { get; set; }
        public Nullable<int> cod_alerta_tc { get; set; }
        public Nullable<int> tarea_asignada_por { get; set; }
        public bool confidencial { get; set; }
        public bool impreso_libro { get; set; }
        public Nullable<int> cod_folder_archivo { get; set; }
        public bool autorizado { get; set; }
        public bool oculto { get; set; }
        public System.Guid rowguid1 { get; set; }
        public string dir { get; set; }
        public Nullable<System.DateTime> fecha_limite_migrado { get; set; }
        public string nom_origen { get; set; }
        public string nom_destino { get; set; }
        public string desc_estado { get; set; }
    }
}
