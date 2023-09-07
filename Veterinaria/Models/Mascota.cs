using System;
using System.Collections.Generic;

namespace Veterinaria.Models;

public partial class Mascota
{
    public int Id { get; set; }

    public string NombreMascota { get; set; } = null!;

    public string EdadMascota { get; set; } = null!;

    public string Raza { get; set; } = null!;
}
