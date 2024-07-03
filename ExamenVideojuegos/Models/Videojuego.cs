using System;
using System.Collections.Generic;

namespace ExamenVideojuegos.Models;

public partial class Videojuego
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public double? Precio { get; set; }

    public string? Categoria { get; set; }

    public string? Imagen { get; set; }
}
