using System.Data.Entity;

namespace Proyecto
{
   class TriviaContext: DbContext
    {
        public DbSet<Pregunta> Preguntas { get; set; }

        public DbSet<Respuesta> Respuestas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Dificultad> Dificultades { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Puntaje> Puntajes { get; set; }
    }

}