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

        public PatronCrecimiento AddPatronCrecimiento(PatronCrecimiento PatronCrecimiento){
            var PatronCrecimientoAdicionado=_appContext.PatronesCrecimiento.Add(PatronCrecimiento);
            _appContext.SaveChanges();
            return PatronCrecimientoAdicionado.Entity;
        }
        
        public PatronCrecimiento GetPatronCrecimiento(int idPatronCrecimiento){
            return _appContext.PatronesCrecimiento.FirstOrDefault(p=>p.Id==idPatronCrecimiento);
        }

    }

}