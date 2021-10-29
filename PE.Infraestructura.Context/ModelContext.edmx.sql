
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/29/2021 15:33:32
-- Generated from EDMX file: C:\Users\santi\source\repos\Private-English-Back\PE.Infraestructura.Context\ModelContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PrivateEnglish];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PersonaDocente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Docentes] DROP CONSTRAINT [FK_PersonaDocente];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alumnos] DROP CONSTRAINT [FK_PersonaAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_UsuarioPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_RolUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK_RolUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_DocenteAula]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aulas] DROP CONSTRAINT [FK_DocenteAula];
GO
IF OBJECT_ID(N'[dbo].[FK_CicloAula]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aulas] DROP CONSTRAINT [FK_CicloAula];
GO
IF OBJECT_ID(N'[dbo].[FK_MateriaAula]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aulas] DROP CONSTRAINT [FK_MateriaAula];
GO
IF OBJECT_ID(N'[dbo].[FK_AlumnoAulaAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AulaAlumnos] DROP CONSTRAINT [FK_AlumnoAulaAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_AulaAulaAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AulaAlumnos] DROP CONSTRAINT [FK_AulaAulaAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_AulaAlumnoAsistencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Asistencias] DROP CONSTRAINT [FK_AulaAlumnoAsistencia];
GO
IF OBJECT_ID(N'[dbo].[FK_DocenteTarea]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tareas] DROP CONSTRAINT [FK_DocenteTarea];
GO
IF OBJECT_ID(N'[dbo].[FK_AulaTarea]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tareas] DROP CONSTRAINT [FK_AulaTarea];
GO
IF OBJECT_ID(N'[dbo].[FK_ArchivoTarea]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tareas] DROP CONSTRAINT [FK_ArchivoTarea];
GO
IF OBJECT_ID(N'[dbo].[FK_AulaAlumnoTareaAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TareaAlumnos] DROP CONSTRAINT [FK_AulaAlumnoTareaAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_TareaTareaAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TareaAlumnos] DROP CONSTRAINT [FK_TareaTareaAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_ArchivoTareaAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TareaAlumnos] DROP CONSTRAINT [FK_ArchivoTareaAlumno];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Personas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas];
GO
IF OBJECT_ID(N'[dbo].[Docentes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Docentes];
GO
IF OBJECT_ID(N'[dbo].[Alumnos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alumnos];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Aulas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aulas];
GO
IF OBJECT_ID(N'[dbo].[Materias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materias];
GO
IF OBJECT_ID(N'[dbo].[Tareas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tareas];
GO
IF OBJECT_ID(N'[dbo].[Ciclos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ciclos];
GO
IF OBJECT_ID(N'[dbo].[AulaAlumnos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AulaAlumnos];
GO
IF OBJECT_ID(N'[dbo].[Asistencias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Asistencias];
GO
IF OBJECT_ID(N'[dbo].[Archivos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Archivos];
GO
IF OBJECT_ID(N'[dbo].[TareaAlumnos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TareaAlumnos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Dni] nvarchar(max)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [Domicilio] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'Docentes'
CREATE TABLE [dbo].[Docentes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Legajo] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL,
    [PersonaId] int  NOT NULL
);
GO

-- Creating table 'Alumnos'
CREATE TABLE [dbo].[Alumnos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Legajo] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL,
    [PersonaId] int  NOT NULL,
    [FechaInscripcion] datetime  NOT NULL,
    [NivelId] int  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [User] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Bloqueado] bit  NOT NULL,
    [Eliminado] nvarchar(max)  NOT NULL,
    [RolId] int  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'Aulas'
CREATE TABLE [dbo].[Aulas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL,
    [DocenteId] int  NOT NULL,
    [CicloId] int  NOT NULL,
    [MateriaId] int  NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Materias'
CREATE TABLE [dbo].[Materias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'Tareas'
CREATE TABLE [dbo].[Tareas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaVencimiento] datetime  NOT NULL,
    [Eliminado] bit  NOT NULL,
    [DocenteId] int  NOT NULL,
    [AulaId] int  NOT NULL,
    [ArchivoId] int  NOT NULL
);
GO

-- Creating table 'Ciclos'
CREATE TABLE [dbo].[Ciclos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'AulaAlumnos'
CREATE TABLE [dbo].[AulaAlumnos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Finalizo] bit  NOT NULL,
    [AlumnoId] int  NOT NULL,
    [AulaId] int  NOT NULL
);
GO

-- Creating table 'Asistencias'
CREATE TABLE [dbo].[Asistencias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Presente] bit  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Eliminado] bit  NOT NULL,
    [AulaAlumnoId] int  NOT NULL
);
GO

-- Creating table 'Archivos'
CREATE TABLE [dbo].[Archivos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UrlDireccion] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'TareaAlumnos'
CREATE TABLE [dbo].[TareaAlumnos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaPresentacion] datetime  NOT NULL,
    [Eliminado] bit  NOT NULL,
    [AulaAlumnoId] int  NOT NULL,
    [TareaId] int  NOT NULL,
    [ArchivoId] int  NOT NULL,
    [Nota] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Niveles'
CREATE TABLE [dbo].[Niveles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Docentes'
ALTER TABLE [dbo].[Docentes]
ADD CONSTRAINT [PK_Docentes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Alumnos'
ALTER TABLE [dbo].[Alumnos]
ADD CONSTRAINT [PK_Alumnos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Aulas'
ALTER TABLE [dbo].[Aulas]
ADD CONSTRAINT [PK_Aulas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Materias'
ALTER TABLE [dbo].[Materias]
ADD CONSTRAINT [PK_Materias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [PK_Tareas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ciclos'
ALTER TABLE [dbo].[Ciclos]
ADD CONSTRAINT [PK_Ciclos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AulaAlumnos'
ALTER TABLE [dbo].[AulaAlumnos]
ADD CONSTRAINT [PK_AulaAlumnos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Asistencias'
ALTER TABLE [dbo].[Asistencias]
ADD CONSTRAINT [PK_Asistencias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Archivos'
ALTER TABLE [dbo].[Archivos]
ADD CONSTRAINT [PK_Archivos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TareaAlumnos'
ALTER TABLE [dbo].[TareaAlumnos]
ADD CONSTRAINT [PK_TareaAlumnos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Niveles'
ALTER TABLE [dbo].[Niveles]
ADD CONSTRAINT [PK_Niveles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonaId] in table 'Docentes'
ALTER TABLE [dbo].[Docentes]
ADD CONSTRAINT [FK_PersonaDocente]
    FOREIGN KEY ([PersonaId])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaDocente'
CREATE INDEX [IX_FK_PersonaDocente]
ON [dbo].[Docentes]
    ([PersonaId]);
GO

-- Creating foreign key on [PersonaId] in table 'Alumnos'
ALTER TABLE [dbo].[Alumnos]
ADD CONSTRAINT [FK_PersonaAlumno]
    FOREIGN KEY ([PersonaId])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaAlumno'
CREATE INDEX [IX_FK_PersonaAlumno]
ON [dbo].[Alumnos]
    ([PersonaId]);
GO

-- Creating foreign key on [UsuarioId] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_UsuarioPersona]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPersona'
CREATE INDEX [IX_FK_UsuarioPersona]
ON [dbo].[Personas]
    ([UsuarioId]);
GO

-- Creating foreign key on [RolId] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK_RolUsuario]
    FOREIGN KEY ([RolId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolUsuario'
CREATE INDEX [IX_FK_RolUsuario]
ON [dbo].[Usuarios]
    ([RolId]);
GO

-- Creating foreign key on [DocenteId] in table 'Aulas'
ALTER TABLE [dbo].[Aulas]
ADD CONSTRAINT [FK_DocenteAula]
    FOREIGN KEY ([DocenteId])
    REFERENCES [dbo].[Docentes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocenteAula'
CREATE INDEX [IX_FK_DocenteAula]
ON [dbo].[Aulas]
    ([DocenteId]);
GO

-- Creating foreign key on [CicloId] in table 'Aulas'
ALTER TABLE [dbo].[Aulas]
ADD CONSTRAINT [FK_CicloAula]
    FOREIGN KEY ([CicloId])
    REFERENCES [dbo].[Ciclos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CicloAula'
CREATE INDEX [IX_FK_CicloAula]
ON [dbo].[Aulas]
    ([CicloId]);
GO

-- Creating foreign key on [MateriaId] in table 'Aulas'
ALTER TABLE [dbo].[Aulas]
ADD CONSTRAINT [FK_MateriaAula]
    FOREIGN KEY ([MateriaId])
    REFERENCES [dbo].[Materias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MateriaAula'
CREATE INDEX [IX_FK_MateriaAula]
ON [dbo].[Aulas]
    ([MateriaId]);
GO

-- Creating foreign key on [AlumnoId] in table 'AulaAlumnos'
ALTER TABLE [dbo].[AulaAlumnos]
ADD CONSTRAINT [FK_AlumnoAulaAlumno]
    FOREIGN KEY ([AlumnoId])
    REFERENCES [dbo].[Alumnos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlumnoAulaAlumno'
CREATE INDEX [IX_FK_AlumnoAulaAlumno]
ON [dbo].[AulaAlumnos]
    ([AlumnoId]);
GO

-- Creating foreign key on [AulaId] in table 'AulaAlumnos'
ALTER TABLE [dbo].[AulaAlumnos]
ADD CONSTRAINT [FK_AulaAulaAlumno]
    FOREIGN KEY ([AulaId])
    REFERENCES [dbo].[Aulas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AulaAulaAlumno'
CREATE INDEX [IX_FK_AulaAulaAlumno]
ON [dbo].[AulaAlumnos]
    ([AulaId]);
GO

-- Creating foreign key on [AulaAlumnoId] in table 'Asistencias'
ALTER TABLE [dbo].[Asistencias]
ADD CONSTRAINT [FK_AulaAlumnoAsistencia]
    FOREIGN KEY ([AulaAlumnoId])
    REFERENCES [dbo].[AulaAlumnos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AulaAlumnoAsistencia'
CREATE INDEX [IX_FK_AulaAlumnoAsistencia]
ON [dbo].[Asistencias]
    ([AulaAlumnoId]);
GO

-- Creating foreign key on [DocenteId] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [FK_DocenteTarea]
    FOREIGN KEY ([DocenteId])
    REFERENCES [dbo].[Docentes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocenteTarea'
CREATE INDEX [IX_FK_DocenteTarea]
ON [dbo].[Tareas]
    ([DocenteId]);
GO

-- Creating foreign key on [AulaId] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [FK_AulaTarea]
    FOREIGN KEY ([AulaId])
    REFERENCES [dbo].[Aulas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AulaTarea'
CREATE INDEX [IX_FK_AulaTarea]
ON [dbo].[Tareas]
    ([AulaId]);
GO

-- Creating foreign key on [ArchivoId] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [FK_ArchivoTarea]
    FOREIGN KEY ([ArchivoId])
    REFERENCES [dbo].[Archivos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArchivoTarea'
CREATE INDEX [IX_FK_ArchivoTarea]
ON [dbo].[Tareas]
    ([ArchivoId]);
GO

-- Creating foreign key on [AulaAlumnoId] in table 'TareaAlumnos'
ALTER TABLE [dbo].[TareaAlumnos]
ADD CONSTRAINT [FK_AulaAlumnoTareaAlumno]
    FOREIGN KEY ([AulaAlumnoId])
    REFERENCES [dbo].[AulaAlumnos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AulaAlumnoTareaAlumno'
CREATE INDEX [IX_FK_AulaAlumnoTareaAlumno]
ON [dbo].[TareaAlumnos]
    ([AulaAlumnoId]);
GO

-- Creating foreign key on [TareaId] in table 'TareaAlumnos'
ALTER TABLE [dbo].[TareaAlumnos]
ADD CONSTRAINT [FK_TareaTareaAlumno]
    FOREIGN KEY ([TareaId])
    REFERENCES [dbo].[Tareas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TareaTareaAlumno'
CREATE INDEX [IX_FK_TareaTareaAlumno]
ON [dbo].[TareaAlumnos]
    ([TareaId]);
GO

-- Creating foreign key on [ArchivoId] in table 'TareaAlumnos'
ALTER TABLE [dbo].[TareaAlumnos]
ADD CONSTRAINT [FK_ArchivoTareaAlumno]
    FOREIGN KEY ([ArchivoId])
    REFERENCES [dbo].[Archivos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArchivoTareaAlumno'
CREATE INDEX [IX_FK_ArchivoTareaAlumno]
ON [dbo].[TareaAlumnos]
    ([ArchivoId]);
GO

-- Creating foreign key on [NivelId] in table 'Alumnos'
ALTER TABLE [dbo].[Alumnos]
ADD CONSTRAINT [FK_NivelAlumno]
    FOREIGN KEY ([NivelId])
    REFERENCES [dbo].[Niveles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NivelAlumno'
CREATE INDEX [IX_FK_NivelAlumno]
ON [dbo].[Alumnos]
    ([NivelId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------