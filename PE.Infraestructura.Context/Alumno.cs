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
    
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            this.AulaAlumno = new HashSet<AulaAlumno>();
        }
    
        public int Id { get; set; }
        public string Legajo { get; set; }
        public bool Eliminado { get; set; }
        public int PersonaId { get; set; }
        public System.DateTime FechaInscripcion { get; set; }
        public int NivelId { get; set; }
    
        public virtual Persona Persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AulaAlumno> AulaAlumno { get; set; }
        public virtual Nivel Nivel { get; set; }
    }
}
