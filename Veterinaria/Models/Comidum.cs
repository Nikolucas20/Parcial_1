using System;
using System.Collections.Generic;

namespace Veterinaria.Models;

public partial class Comidum
{
    public int Id { get; set; }

    public string TipoComida { get; set; } = null!;

    public string TipoMascota { get; set; } = null!;

    public int Precio { get; set; }
}
