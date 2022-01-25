using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyApp.Models
{
    public class Curso
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }
        public List<RegistroCurso> RegistroCursos { get; set; }

    }
}