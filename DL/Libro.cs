using System;
using System.Collections.Generic;

namespace DL;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Titulo { get; set; } = null!;

    public string? AñoPublicacion { get; set; }

    public int? Autor { get; set; }

    public int? Editorial { get; set; }

    public virtual Autor? AutorNavigation { get; set; }

    public virtual Editorial? EditorialNavigation { get; set; }
}
