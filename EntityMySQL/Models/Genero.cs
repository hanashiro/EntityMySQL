using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityMySQL.Models
{
    [Table("Genero")]
    public class Genero
    {
        public int ID { get; set; }
        public string Nome { get; set; }
    }
}