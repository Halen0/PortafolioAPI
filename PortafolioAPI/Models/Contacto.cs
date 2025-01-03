using System;
using System.Collections.Generic;

namespace PortafolioAPI.Models;

public partial class Contacto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Asunto { get; set; }

    public string? Mensaje { get; set; }
}
