
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoHogar.App.Persistencia;
using ProyectoHogar.App.Dominio;

namespace ProyectoHogar.App.Presentacion.Pages;

public class IndexModel : PageModel
{
    private readonly IRepositorioPacienteMemoria RepositorioPacienteMemoria;
    public IEnumerable<Paciente> Pacientes {get;set;}

    public IndexModel(IRepositorioPacienteMemoria RepositorioPacienteMemoria)
    {
        this.RepositorioPacienteMemoria = RepositorioPacienteMemoria;
    }

    public void OnGet()
    {
        Pacientes=RepositorioPacienteMemoria.GetAll();
    }
}
