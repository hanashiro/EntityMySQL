using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityMySQL.Models
{

    public class Contexto : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        public Contexto()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
            
        }

    }
}