using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyApp.Models
{
    public class Estudiante
    {
       [Key] 
       public int ID { get; set; }
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       public string DocumentoIdentidad { get; set; }
       public DateTime FechaNacimiento { get; set; }
       public List<RegistroCurso> RegistroCursos { get; set; }
    }
}