namespace ProyectoHogar.App.Dominio{
    public class Medico:Persona{
        
        public Especialidad especialidad{get;set;}
        public string? TarjetaProfesional{get; set;}//cantidad horas laborales a la semana
        public int? HorasLaborales{get; set;}
 }

}

 