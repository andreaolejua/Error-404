
using System;
using ProyectoHogar.App.Dominio;
using ProyectoHogar.App.Persistencia;
namespace ProyectoHogar.App.Console
{
    class Program{
        private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioPatronCrecimiento _repoHistoria=new RepositorioPatronCrecimiento(new Persistencia.AppContext());
        private static IRepositorioFamiliar _repoFamiliar=new RepositorioFamiliar(new Persistencia.AppContext());
        private static IRepositorioMedico _repoMedico=new RepositorioMedico(new Persistencia.AppContext());
            static void Main(string[] args){
                    System.Console.WriteLine("Hello, Error 404!");
                    //AddPaciente();
                    //AddHistoria();
                    //GetAllPacientes();
                    //GetPaciente(1);
                    //GetAllPacientes();
                    //var paciente=GetPaciente(1);
                    //UpdatePaciente(paciente);
                    //paciente=GetPaciente(1);
                    //ToAssignPatron();
 }
            private static void AddPaciente(){
                //var historia= _repoHistoria.GetHistoria(1);

                var paciente=new Paciente{
                    Nombre="Deison",
                    Apellidos="Palacios",
                    Telefono="34556554",
                    Documento="3465654765",
                    Genero=Genero.Masculino,
                    Ciudad="Bogota",
                    FechaNacimiento=new DateTime(2002,11,25),    
                };
                _repoPaciente.AddPaciente(paciente);
            }
            private static void GetAllPacientes(){
                var pacientes=_repoPaciente.GetAllPacientes();
                foreach (var paciente in pacientes){
                    System.Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
                }
            }

            private static void AddHistoria(){
                var patronCrecimiento=new PatronCrecimiento{
                    Diagnostico="Historia 5",  
                };
                _repoHistoria.AddPatronCrecimiento(patronCrecimiento);
            }   

            private static Paciente GetPaciente(int idPaciente){
                var paciente=_repoPaciente.GetPaciente(idPaciente);
                System.Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
                return paciente;
            }

            private static void UpdatePaciente(Paciente paciente){
                paciente.Nombre="Mariana";
                paciente.Apellidos="Trujillo";
                paciente.Documento="435343232";
                _repoPaciente.UpdatePaciente(paciente);
            }

            private static void ToAssignPatron(){
                var patronCrecimiento=_repoPaciente.ToAssignPatron(1,1);
                System.Console.WriteLine(patronCrecimiento.Diagnostico);
            }

    }

}   

