using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class RegistroCurso
    {
        [Key]
        public int ID { get; set; }
        public int EstudianteID { get; set; }
        public Estudiante Estudiante { get; set; }
        public int CursoID { get; set; }
        public Curso Curso { get; set; }

    }
}