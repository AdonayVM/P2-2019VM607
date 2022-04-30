using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2_2019VM607.Models
{
    public class caso
    {
        [Key]
        public int id_caso { get; set; }
        public string departamento { get; set; }
        public string genero { get; set; }
        public int confirmados { get; set; }
        public int recuperados { get; set; }
        public int fallecidos { get; set; }
    }
}
