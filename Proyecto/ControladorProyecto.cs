using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Web;
using System.Threading.Tasks;
namespace Proyecto
{

    internal static class ControladorProyecto
    {

        public static void AgregarUsuario (Usuario pUser)
        {
            using (TriviaContext db = new TriviaContext())
            {
                db.Usuarios.Add(pUser);
                db.SaveChanges();
            }
        }

        public static bool NombreUsuarioExistente(string pNombreUsuario)
        {
            using (TriviaContext db = new TriviaContext())
            {
                Usuario mUsuario = db.Usuarios.ToList().FirstOrDefault(usr => usr.NombreUsuario == pNombreUsuario);
                if (mUsuario == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                //if (db.Usuarios.Count() > 0)
                //{
                    
                //}
                //else
                //{
                //    return false;
                //}
            }
        }

        public static Usuario ObtenerUsuario(string pNombreUsuario, string pPassword)
        {
            using (TriviaContext db = new TriviaContext())
            {
                Usuario mUsuario = db.Usuarios.ToList().FirstOrDefault(usr => (usr.NombreUsuario == pNombreUsuario) & (usr.Password == pPassword));
                return mUsuario;
            }
        }

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
                    Categoria mCategoria = db.Categorias.FirstOrDefault(cat => cat.NombreCategoria == bItem.Categoria.NombreCategoria);
                    if (mCategoria == null)
                    {
                        db.Categorias.Add(bItem.Categoria);
                        mCategoria = db.Categorias.First(cat => cat.NombreCategoria == bItem.Categoria.NombreCategoria);
                    }

                    Dificultad mDificultad = db.Dificultades.First(dif => dif.NombreDificultad == bItem.Dificultad.NombreDificultad);
                    bItem.Categoria = mCategoria;
                    bItem.Dificultad = mDificultad;
                    db.Preguntas.Add(bItem);
                }

                db.SaveChanges();
            }
        }



        public static void AgregarPorUrl(Categoria pCategoria, Dificultad pDificultad, int pCantidad)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var mUrl = GenerarLink(pCategoria, pDificultad, pCantidad);
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            //try
            //{
                WebResponse mResponse = mRequest.GetResponse();
                List<Pregunta> lPreguntas = new List<Pregunta>();
                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    foreach (var bResponseItem in mResponseJSON.results)
                    {
                        String mLaPregunta = HttpUtility.HtmlDecode(bResponseItem.question.ToString());
                        List<Respuesta> lRespuestas = new List<Respuesta>();

                        Respuesta mRespCorrecta = new Respuesta(HttpUtility.HtmlDecode(bResponseItem.correct_answer.ToString()), true);
                        lRespuestas.Add(mRespCorrecta);
                        foreach (var bRespInc in bResponseItem.incorrect_answers)
                        {
                            lRespuestas.Add(new Respuesta(HttpUtility.HtmlDecode(bRespInc.ToString()), false));
                        }

                        Pregunta mPregunta = new Pregunta(mLaPregunta, pCategoria, pDificultad, lRespuestas);
                        lPreguntas.Add(mPregunta);
                    }

                    AgregarPreguntas(lPreguntas);
                }
            //}

            //catch (WebException ex)
            //{
            //    WebResponse mErrorResponse = ex.Response;
            //    using (Stream mResponseStream = mErrorResponse.GetResponseStream())
            //    {
            //        StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
            //        String mErrorText = mReader.ReadToEnd();



            //        System.Console.WriteLine("Error: {0}", mErrorText);
            //    }
            //}

            //catch (Exception ex)
            //{
            //    System.Console.WriteLine("Error: {0}", ex.Message);
            //}
        }

        public static string GenerarLink(Categoria pCategoria, Dificultad pDificultad, int pCantidad)
        {

            // Url de ejemplo
            string mUrl = "https://opentdb.com/api.php?amount=" + pCantidad.ToString() + "&category=" + pCategoria.IdWeb.ToString() + "&difficulty=" + pDificultad.NombreDificultad.ToString() + "&type=multiple";

            return mUrl;
        }

        
        /// <summary>
        /// Agrega una nueva categoría a la base de datos
        /// </summary>
        /// <param name="pCategoria"></param>
        public static void AgregarCategoria(Categoria pCategoria)
        {

            using (TriviaContext db = new TriviaContext())
            {
                db.Categorias.Add(pCategoria);

                db.SaveChanges();
            }
        }

        public static void AgregarPuntaje(Usuario pUsuario, Puntaje pPuntaje)
        {
            using (TriviaContext db = new TriviaContext())
            {
                pPuntaje.Usuario = db.Usuarios.Find(pUsuario.IdUsuario);
                db.Puntajes.Add(pPuntaje);
                db.SaveChanges();
            }
        }


        public static Categoria ObtenerCategoria(int pId)
        {

            if (pId.GetType() == typeof(String))
            {
                pId = Convert.ToInt32(pId);
            }
            using (TriviaContext db = new TriviaContext())
            {
                Categoria iCategoria = db.Categorias.Find(pId);
                return iCategoria;
            }
        }

        public static Dificultad ObtenerDificultad(int pId)
        {
            if (pId.GetType() != typeof(Int32))
            {
                pId = Convert.ToInt32(pId);
            }
            using (TriviaContext db = new TriviaContext())
            {
                Dificultad iDificultad = db.Dificultades.Find(pId);
                return iDificultad;
            }
        }

        public static List<Pregunta> ObtenerListaPregunta(Categoria pCategoria, Dificultad pDificultad, int pCantidad)
        {
            List<Pregunta> mLPreguntas = new List<Pregunta>();

            using (TriviaContext db = new TriviaContext())
            {
                List<Pregunta> mLPregDeCat = db.Preguntas
                    .Include("Categoria")
                    .Include("Dificultad")
                    .Include("Respuestas")
                    .Where(preg => (preg.Categoria.IdCategoria == pCategoria.IdCategoria) && (preg.Dificultad.NombreDificultad == pDificultad.NombreDificultad)).ToList();
                int mCount = mLPregDeCat.Count;
                Random mRandom = new Random();
               
                int i = 0;
                while (i < pCantidad)
                {
                    int mIndex = mRandom.Next(mCount);
                    Pregunta mPregunta = mLPregDeCat[mIndex];
                    if (mLPreguntas.FirstOrDefault(preg => preg.LaPregunta == mPregunta.LaPregunta) == null)
                    {
                        mLPreguntas.Add(mPregunta);
                        i++;
                    }
                }
                return mLPreguntas;
            }
        }


        public static List<Respuesta> ObtenerListaRandomRespuestas(Pregunta pPregunta)
        {
            Random pRandom = new Random();
            return pPregunta.Respuestas.OrderBy(r => pRandom.Next()).ToList();
        }


        public static List<Puntaje> ObtenerListaPuntajes()
        {
            using (TriviaContext db = new TriviaContext())
            {
                return db.Puntajes.Include("Usuario").OrderByDescending(punt => punt.ValorPuntaje).Take(20).ToList();
            }
        }









        public static void HardcodeamelasCategoriasmaestro()
        {
            for (int i = 9; i <= 32; i++)
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var mUrl = "https://opentdb.com/api.php?amount=1&category=" + i.ToString();

                HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

                WebResponse mResponse = mRequest.GetResponse();

                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    foreach (var bResponseItem in mResponseJSON.results)
                    {
                        String mNombreCategoria = HttpUtility.HtmlDecode(bResponseItem.category.ToString());
                        Categoria mCategoria = new Categoria(mNombreCategoria, i);

                        AgregarCategoria(mCategoria);
                    }
                }
            }
        }

        public static void Hardcodeameladificultadmaestro()
        {
            using (TriviaContext db = new TriviaContext())
            {
                Dificultad facil = new Dificultad("easy", 1);
                Dificultad normal = new Dificultad("normal", 3);
                Dificultad dificil = new Dificultad("hard", 5);
                db.Dificultades.Add(facil);
                db.Dificultades.Add(normal);
                db.Dificultades.Add(dificil);
                db.SaveChanges();
            }
        }

    }
}