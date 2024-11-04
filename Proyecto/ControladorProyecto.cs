using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
namespace Proyecto
{

    internal static class ControladorProyecto
    {
        private static TriviaContext db;

        static ControladorProyecto()
        {
            db = new TriviaContext();
        }
        public static void AgregarUsuario (Usuario pUser)
        {
                db.Usuarios.Add(pUser);
                db.SaveChanges();
        }

        public static bool NombreUsuarioExistente(string pNombreUsuario)
        {
                Usuario mUsuario = db.Usuarios.FirstOrDefault(usr => usr.NombreUsuario == pNombreUsuario);
                if (mUsuario != null)
                {
                    return true;
                }
                return false;
                //if (db.Usuarios.Count() > 0)
                //{
                    
                //}
                //else
                //{
                //    return false;
                //}
        }

        public static Usuario ObtenerUsuario(string pNombreUsuario, string pPassword)
        {
                Usuario mUsuario = db.Usuarios.FirstOrDefault(usr => (usr.NombreUsuario == pNombreUsuario) & (usr.Password == pPassword));
                return mUsuario;
        }

        /// <summary>
        /// Agrega una lista de preguntas a la base de datos
        /// </summary>
        /// <param name="pPreguntas">Lista de preguntas a agregar</param>
        public static void AgregarPreguntas(IList<Pregunta> pPreguntas)
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



            //        System.Debug.WriteLine("Error: {0}", mErrorText);
            //    }
            //}

            //catch (Exception ex)
            //{
            //    System.Debug.WriteLine("Error: {0}", ex.Message);
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
                // TODO: Si no existe que lo agregue, y try catch please
                db.Categorias.Add(pCategoria);

                db.SaveChanges();
        }

        public static void AgregarPuntaje(Usuario pUsuario, Puntaje pPuntaje)
        {
                pPuntaje.Usuario = db.Usuarios.Find(pUsuario.IdUsuario);
                db.Puntajes.Add(pPuntaje);
                db.SaveChanges();
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
                Dificultad iDificultad = db.Dificultades.Find(pId);
                return iDificultad;
        }

        public static List<Pregunta> ObtenerListaPregunta(Categoria pCategoria, Dificultad pDificultad, int pCantidad)
        {
            List<Pregunta> mLPreguntas = new List<Pregunta>();
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


        public static List<Respuesta> ObtenerListaRandomRespuestas(Pregunta pPregunta)
        {
            Random pRandom = new Random();
            return pPregunta.Respuestas.OrderBy(r => pRandom.Next()).ToList();
        }


        public static List<Puntaje> ObtenerListaPuntajes()
        {
                return db.Puntajes.Include("Usuario").OrderByDescending(punt => punt.ValorPuntaje).Take(20).ToList();
        }


        public static async void InicializarCategorias()
        {
            if (db.Categorias.ToList().Count < 23)
            {
                for (int i = 9; i <= 32; i++)
                {
                    if (db.Categorias.FirstOrDefault(cat => cat.IdWeb == i) != null)
                    {
                        continue;
                    };
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    var mUrl = "https://opentdb.com/api.php?amount=1&category=" + i.ToString();
                    using (HttpClient client = new HttpClient())
                    {
                        int maxRetries = 5; // Número máximo de reintentos
                        int delay = 2000; // Retraso inicial en milisegundos

                        for (int retry = 0; retry < maxRetries; retry++)
                        {
                            try
                            {
                                // Hacer la solicitud GET
                                string json = await client.GetStringAsync(mUrl);
                                dynamic triviaResponse = JsonConvert.DeserializeObject<Object>(json);

                                // Procesar la respuesta
                                foreach (var bResponseItem in triviaResponse?.results)
                                {
                                    String mNombreCategoria = HttpUtility.HtmlDecode(bResponseItem.category.ToString());
                                    Categoria mCategoria = new Categoria(mNombreCategoria, i);

                                    AgregarCategoria(mCategoria);
                                }
                                break; // Salir del bucle si la solicitud fue exitosa
                            }
                            catch (HttpRequestException ex) when (ex.Message.Contains("429"))
                            {
                                Debug.WriteLine("Too Many Requests. Retrying...");
                                await Task.Delay(delay); // Esperar antes de reintentar
                                delay *= 2; // Incrementar el retraso para el siguiente intento (backoff exponencial)
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"Error: {ex.Message}");
                                break; // Salir del bucle en caso de otro error
                            }
                        }
                    }
                }
            }
        }

        public static void InicializarDificultades()
        {
            using (TriviaContext db = new TriviaContext())
            {
                List<Dificultad> dificultades = new List<Dificultad>();
                dificultades.Add(new Dificultad("easy", 1));
                dificultades.Add(new Dificultad("normal", 3));
                dificultades.Add(new Dificultad("hard", 5));
                foreach (Dificultad dificultad in dificultades)
                {
                   if (db.Dificultades.FirstOrDefault(dif => dif.NombreDificultad == dificultad.NombreDificultad) == null)
                    {
                        db.Dificultades.Add(dificultad);
                    }
                }
                db.SaveChanges();
            }
        }

    }
}