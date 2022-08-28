namespace ProyectoHogar.App.Dominio{

    public class Paciente:Persona{
        public string Direccion{get; set;}
        public string Ciudad{get; set;}
        public DateTime FechaNacimiento{get; set;}
        public Familiar familiar{get; set;}
        public PatronCrecimiento patronCrecimiento{get; set;}
    }
}