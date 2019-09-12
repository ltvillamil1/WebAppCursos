using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppCursos.Models;

namespace WebAppCursos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAppCursos.Models.Asignacion> Asignacion { get; set; }
        public DbSet<WebAppCursos.Models.Categoria> Categoria { get; set; }
        public DbSet<WebAppCursos.Models.Curso> Curso { get; set; }
        public DbSet<WebAppCursos.Models.Estudiante> Estudiante { get; set; }
        public DbSet<WebAppCursos.Models.Inscripcion> Inscripcion { get; set; }
        public DbSet<WebAppCursos.Models.Instructor> Instructor { get; set; }
    }
}
