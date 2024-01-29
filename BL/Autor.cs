using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Autor
    {
        public static List<object> GetAllAutor()
        {
            List<object> Autores = new List<object>();
            try
            {
                using (DL.LibrosContext context = new DL.LibrosContext())
                {
                    var query = (from autor in context.Autors
                                 select new
                                 {
                                     IdAutor = autor.IdAutor,
                                     Nombre = autor.Nombre,
                                     ApellidoPaterno = autor.ApellidoPaterno,
                                     ApellidoMaterno = autor.ApellidoMaterno,
                                 });
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.Autor autor = new ML.Autor();
                            autor.IdAutor = item.IdAutor;
                            autor.Nombre = item.Nombre;
                            autor.ApellidoPaterno = item.ApellidoPaterno;
                            autor.ApellidoMaterno = item.ApellidoMaterno;
                            Autores.Add(autor);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return Autores;
        }
    }
}

