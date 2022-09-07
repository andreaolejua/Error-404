using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoHogar.App.Dominio;

namespace ProyectoHogar.App.Persistencia
{
    
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;
        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Paciente> GetAllPacientes(){
            return _appContext.Pacientes;
        }

        public Paciente AddPaciente(Paciente paciente){
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);    
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        public Paciente UpdatePaciente(Paciente paciente){
            var pacienteEncontrado=_appContext.Pacientes.FirstOrDefault(p=>p.Id==paciente.Id);
                if(pacienteEncontrado!=null){
                    pacienteEncontrado.Nombre=paciente.Nombre;
                    pacienteEncontrado.Apellidos=paciente.Apellidos;
                    pacienteEncontrado.Telefono=paciente.Telefono;
                    pacienteEncontrado.Documento=paciente.Documento;
                    pacienteEncontrado.Genero=paciente.Genero;
                    pacienteEncontrado.Direccion=paciente.Direccion;
                    pacienteEncontrado.Ciudad=paciente.Ciudad;
                    pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
                    pacienteEncontrado.familiar=paciente.familiar;
                    pacienteEncontrado.Nutricionista=paciente.Nutricionista;
                    pacienteEncontrado.Pediatra=paciente.Pediatra;
                    pacienteEncontrado.patronCrecimiento=paciente.patronCrecimiento;
                    _appContext.SaveChanges();
                    //telefono,documento,genero,direccion,ciudad,FechaNacimiento,familiar,nutricionista,pediatra,patronCrecimiento
                }
                return pacienteEncontrado;
        }
        public void DeletePaciente(int idPaciente){
            var pacienteEncontrado=_appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
            if(pacienteEncontrado==null){
                return;
            }
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }
        public Paciente GetPaciente(int idPaciente){
            return _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
        }

        public PatronCrecimiento ToAssignPatron(int idPaciente, int idPatronCrecimiento){
            var paciente=_appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
            if (paciente!=null)
            {
                var patronCrecimiento=_appContext.PatronesCrecimiento.FirstOrDefault(h=>h.Id==idPatronCrecimiento);
                if (patronCrecimiento!=null)
                {
                    paciente.patronCrecimiento=patronCrecimiento;
                    _appContext.SaveChanges();
                }
                return patronCrecimiento;
            }
            return null;
        }
}
    }
