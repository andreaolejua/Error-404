namespace ProyectoHogar.App.Dominio{
    public class PatronCrecimiento{
        public int Id{get; set;}
        public string Diagnostico{get; set;}     
        public System.Collections.Generic.List<SugerenciaCuidado> Sugerencias{get; set;}
        public DateTime Fecha{get; set;}
    }
}