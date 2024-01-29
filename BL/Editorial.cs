using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Editorial
    {
        public static List<object> GetAll()
        {
            List<object> Editoriales = new List<object>();
            try
            {
                using(DL.LibrosContext context = new DL.LibrosContext())
                {
                    var query = (from editorial in context.Editorials
                                 select new
                                 {
                                     IdEditorial = editorial.IdEditorial,
                                     Nombre = editorial.Nombre,
                                 });
                    if(query != null)
                    {
                        foreach(var item in query)
                        {
                            ML.Editorial editorial = new ML.Editorial();
                            editorial.IdEditorial=item.IdEditorial;
                            editorial.Nombre=item.Nombre;
                            Editoriales.Add(editorial);
                        }
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Editoriales;
        }
    }
}
