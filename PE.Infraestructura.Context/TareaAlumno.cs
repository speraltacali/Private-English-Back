//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PE.Infraestructura.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class TareaAlumno
    {
        public int Id { get; set; }
        public System.DateTime FechaPresentacion { get; set; }
        public bool Eliminado { get; set; }
        public int AulaAlumnoId { get; set; }
        public int TareaId { get; set; }
        public int ArchivoId { get; set; }
        public decimal Nota { get; set; }
    
        public virtual AulaAlumno AulaAlumno { get; set; }
        public virtual Tarea Tarea { get; set; }
        public virtual Archivo Archivo { get; set; }
    }
}
