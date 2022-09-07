using ProyectoHogar.App.Dominio;
using System.Collections.Generic;

namespace ProyectoHogar.App.Persistencia{
    public interface IRepositorioPaciente{
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
}
}