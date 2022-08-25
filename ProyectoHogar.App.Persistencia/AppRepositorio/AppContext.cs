namespace ProyectoHogar.App.Persistencia.AppRepositorio
{

    using Microsoft.EntityFrameworkCore;
    using ProyectoHogar.App.Dominio;
    using ProyectoHogar.App.Persistencia;

    public class AppContext:DbContext{
        public DbSet<Persona> Personas{get; set;}
        public DbSet<Pediatra> Pediatras{get; set;}
        public DbSet<Familiar> Familiares{get; set;}
        public DbSet<PatronCrecimiento> PatronesCrecimiento{get; set;}
        public DbSet<Paciente> Pacientes{get; set;}
        public DbSet<Hogar> Hogares{get; set;}
        public DbSet<SugerenciaCuidado> SugerenciasCuidados{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             if (optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=ProyectoHogar");
             }
        }
    }
}

