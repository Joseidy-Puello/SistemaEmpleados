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
            new Empleado { Id=1, Nombre="María García", Departamento="RRHH",Salario=35000m, Activo=true  },
            new Empleado { Id=2, Nombre="Juan Pérez", Departamento="Tecnología",  Salario=42000m, Activo=true  },
            new Empleado { Id=3, Nombre="Rosa Martínez",  Departamento="Finanzas", Salario=38000m, Activo=true  },
            new Empleado { Id=4, Nombre="Pedro Gómez", Departamento="Operaciones", Salario=28000m, Activo=false },
        };

        return View(lista);  // envía la lista completa a la View
    }
}