using System;
using System.Collections.Generic;

namespace Veterinaria.Models;

public partial class Dueño
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Edad { get; set; }

    public string Direccion { get; set; } = null!;

    public string TipoMascota { get; set; } = null!;
}
