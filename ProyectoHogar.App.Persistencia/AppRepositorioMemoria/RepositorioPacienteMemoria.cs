using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using ProyectoHogar.App.Dominio;

namespace ProyectoHogar.App.Persistencia{
    public class RepositorioPacienteMemoria:IRepositorioPacienteMemoria
    {
        List<Paciente> Pacientes;
        public RepositorioPacienteMemoria(){
            Pacientes=new List<Paciente>(){
                new Paciente{
                    Nombre="Mauricio",
                    Apellidos="Gallego",
                    Telefono="3108327261",
                    Documento="100234876253",
                    Genero=Genero.Masculino,
                    Ciudad="Manizales",
                    FechaNacimiento=new DateTime(2010,11,12)
                }
            };

        }
    }
}