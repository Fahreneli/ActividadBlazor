using System;

namespace Tp02.Models;


public class Persona
{
    public int Id { get; set; }
    public string NombreCompleto { get; set; }
    public string Email { get; set; }   
    public string Domicilio { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string RutaImagen { get; set; }
}
