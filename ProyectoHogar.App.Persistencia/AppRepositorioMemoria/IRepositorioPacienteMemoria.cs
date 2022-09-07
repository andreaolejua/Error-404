using System;
using System.Collections.Generic;
using ProyectoHogar.App.Dominio;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHogar.App.Persistencia
{
    public interface IRepositorioPacienteMemoria
    {
        public IEnumerable<Paciente> GetAll(){
            throw new NotImplementedException();
        }
        public Paciente Add(Paciente paciente){
            throw new NotImplementedException();
        }
        public Paciente Update(Paciente paciente){
            throw new NotImplementedException();
        }
        public void Delete(int idPaciente){
            throw new NotImplementedException();
        }
        public Paciente Get(int idPaciente){
            throw new NotImplementedException();
        }
    }
}