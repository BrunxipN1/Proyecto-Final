using System.Data.Entity;

namespace Proyecto
{
   class TriviaContext: DbContext
    {
        public DbSet<Pregunta> Pregunta { get; set; }

        public DbSet<Respuesta> Respuesta { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Dificultad> Dificultad { get; set; }
    }

}