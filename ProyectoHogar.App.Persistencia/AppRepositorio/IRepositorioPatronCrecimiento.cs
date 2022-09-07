using System.Collections.Generic;
using ProyectoHogar.App.Dominio;

namespace ProyectoHogar.App.Persistencia{

    public interface IRepositorioPatronCrecimiento
    {
       // IEnumerable<PatronCrecimiento>GetAllPatronCrecimiento();
        PatronCrecimiento AddPatronCrecimiento(PatronCrecimiento PatronCrecimiento);
        // PatronCrecimiento UpdatePatronCrecimiento(PatronCrecimiento PatronCrecimiento);
        // void DeletePatronCrecimiento(int idPatronCrecimiento);
        // PatronCrecimiento GetPatronCrecimiento(int idPatronCrecimiento);

    }

}