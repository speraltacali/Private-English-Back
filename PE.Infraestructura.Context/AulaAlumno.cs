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
    
    public partial class AulaAlumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AulaAlumno()
        {
            this.Asistencia = new HashSet<Asistencia>();
            this.TareaAlumno = new HashSet<TareaAlumno>();
        }
    
        public int Id { get; set; }
        public bool Finalizo { get; set; }
        public int AlumnoId { get; set; }
        public int AulaId { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Aula Aula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asistencia> Asistencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TareaAlumno> TareaAlumno { get; set; }
    }
}
