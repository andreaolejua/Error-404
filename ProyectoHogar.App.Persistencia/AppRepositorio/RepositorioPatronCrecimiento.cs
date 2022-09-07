using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProyectoHogar.App.Dominio;

namespace ProyectoHogar.App.Persistencia
{

    
    public class RepositorioPatronCrecimiento : IRepositorioPatronCrecimiento
    {
        private readonly AppContext _appContext;
        public RepositorioPatronCrecimiento (AppContext appContext){
            _appContext=appContext;
        }

        public PatronCrecimiento AddPatronCrecimiento(PatronCrecimiento patronCrecimiento){
            var PatronCrecimientoAdicionado=_appContext.PatronesCrecimiento.Add(patronCrecimiento);
            _appContext.SaveChanges();
            return PatronCrecimientoAdicionado.Entity;
        }
        
        public PatronCrecimiento GetPatronCrecimiento(int idPatronCrecimiento){
            return _appContext.PatronesCrecimiento.FirstOrDefault(h=>h.Id==idPatronCrecimiento);
        }   
        public PatronCrecimiento UpdatePatronCrecimiento(PatronCrecimiento patronCrecimiento){
            var patronEncontrado=_appContext.PatronesCrecimiento.FirstOrDefault(h=>h.Id==patronCrecimiento.Id);
                if (patronEncontrado!=null)
                {
                    patronEncontrado.Diagnostico=patronCrecimiento.Diagnostico;
                    _appContext.SaveChanges();
                }
                return patronEncontrado;
        }

        public void DeletePatronCrecimiento(int idPatronCrecimiento){
            var patronEncontrado=_appContext.PatronesCrecimiento.FirstOrDefault(h=>h.Id==idPatronCrecimiento);
            if(patronEncontrado==null){
                return;
            }
            _appContext.PatronesCrecimiento.Remove(patronEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<PatronCrecimiento> GetAllPatronesCrecimiento(){
            return _appContext.PatronesCrecimiento;
        }
            

        }


}