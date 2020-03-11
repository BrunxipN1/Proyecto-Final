using System;
using System.Collections.Generic;
namespace Proyecto
{

    internal static class ControladorProyecto
    {
        /// <summary>
        /// Agrega una lista de preguntas a la base de datos
        /// </summary>
        /// <param name="pPreguntas">Lista de preguntas a agregar</param>
        public static void AgregarPreguntas(IList<Pregunta> pPreguntas)
        {
            using (TriviaContext db = new TriviaContext())
            {
                foreach (Pregunta bItem in pPreguntas)
                {
                    db.Pregunta.Add(bItem);
                }

                db.SaveChanges();
            }
        }
        /// <summary>
        /// Agrega una nueva categoría a la base de datos
        /// </summary>
        /// <param name="pCategoria"></param>
        public static void AgregarCategoria(Categoria pCategoria)
        {
            using (TriviaContext db = new TriviaContext())
            {
                db.Categoria.Add(pCategoria);

                db.SaveChanges();
            }
        }
        //public void HARDCODEAMELADIFICULTADMAESTRO()
        //{
        //    using (TriviaContext db = iContext)
        //    {
        //        Dificultad facil = new Dificultad("Easy", 1);
        //        Dificultad normal = new Dificultad("Normal", 3);
        //        Dificultad dificil = new Dificultad("Hard", 5);
        //        db.Dificultad.Add(facil);
        //        db.Dificultad.Add(normal);
        //        db.Dificultad.Add(dificil);
        //        db.SaveChanges();
        //    }
        //}

    }
}