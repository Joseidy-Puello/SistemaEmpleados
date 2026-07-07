using System.Numerics;
using Microsoft.AspNetCore.Mvc;
using SistemaEmpleados.Models;

namespace SistemaEmpleados.Controllers;

public class EmpleadoController : Controller
{
    public IActionResult Index()
    {
        // Lista hardcodeada — sin base de datos 
        var lista = new List<Empleado>
        {
            new Empleado { Id=1, Nombre="Neiry Rachel", Departamento="RRHH",Salario=350000m, Activo=true  },
            new Empleado { Id=2, Nombre="Jeiferson David", Departamento="Tecnología",  Salario=4200m, Activo=true  },
            new Empleado { Id=3, Nombre="Dubenny Areche",  Departamento="Finanzas", Salario=7500m, Activo=true  },
            new Empleado { Id=4, Nombre="Ronaldiño Reyes", Departamento="Operaciones", Salario=280000m, Activo=false },
        };

        return View(lista);  // envía la lista completa a la View
    }
}