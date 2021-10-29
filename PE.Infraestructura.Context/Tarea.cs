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
    
    public partial class Tarea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarea()
        {
            this.TareaAlumno = new HashSet<TareaAlumno>();
        }
    
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public bool Eliminado { get; set; }
        public int DocenteId { get; set; }
        public int AulaId { get; set; }
        public int ArchivoId { get; set; }
    
        public virtual Docente Docente { get; set; }
        public virtual Aula Aula { get; set; }
        public virtual Archivo Archivo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TareaAlumno> TareaAlumno { get; set; }
    }
}
