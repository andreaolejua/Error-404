
using System;
using ProyectoHogar.App.Dominio;
using ProyectoHogar.App.Persistencia;
namespace ProyectoHogar.App.Console
{
    class Program{
        private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioPatronCrecimiento _repoHistoria=new RepositorioPatronCrecimiento(new Persistencia.AppContext());
            static void Main(string[] args){
                    System.Console.WriteLine("Hello, Grupo68!");
                    AddPaciente();
                    AddHistoria();
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
            private static void AddHistoria(){
                var patronCrecimiento=new PatronCrecimiento{
                    Diagnostico="Historia 5",  
                };
                _repoHistoria.AddPatronCrecimiento(patronCrecimiento);
            }   

    }

}   

