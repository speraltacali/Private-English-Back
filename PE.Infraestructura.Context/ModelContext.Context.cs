﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelContextContainer : DbContext
    {
        public ModelContextContainer()
            : base("name=ModelContextContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Docente> Docentes { get; set; }
        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Aula> Aulas { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<Tarea> Tareas { get; set; }
        public virtual DbSet<Ciclo> Ciclos { get; set; }
        public virtual DbSet<AulaAlumno> AulaAlumnos { get; set; }
        public virtual DbSet<Asistencia> Asistencias { get; set; }
        public virtual DbSet<Archivo> Archivos { get; set; }
        public virtual DbSet<TareaAlumno> TareaAlumnos { get; set; }
        public virtual DbSet<Nivel> Niveles { get; set; }
    }
}
