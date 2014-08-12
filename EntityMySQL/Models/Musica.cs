using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityMySQL.Models
{
    [Table("Musica")]
    public class Musica
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public virtual Artista Artista { get; set; }
        public virtual Genero Genero { get; set; }
    }
}