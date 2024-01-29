using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {
        public List<object> GetAll()
        {
            List<object> Libros = new List<object>();
            try
            {
                using(DL.LibrosContext context = new DL.LibrosContext())
                {
                    var query = (from libro in context.Libros
                                 join autor in context.Autors on libro.Autor equals autor.IdAutor
                                 join editorial in context.Editorials on libro.Editorial equals editorial.IdEditorial
                                 select new
                                 {
                                     IdLibro = libro.IdLibro,
                                     Titulo = libro.Titulo,
                                     AñoPublicacion = libro.AñoPublicacion,
                                     Autor = libro.Autor,
                                     NombreAutor = libro.AutorNavigation.Nombre,
                                     Editorial = libro.Editorial,
                                     NombreEditorial = libro.EditorialNavigation.Nombre,
                                 }) ;
                    if(query != null )
                    {
                        foreach( var item in query)
                        {
                            ML.Libro libro = new ML.Libro();
                            libro.Editorial = new ML.Editorial();
                            libro.Autor = new ML.Autor();
                            libro.IdLibro = item.IdLibro;
                            libro.Titulo = item.Titulo;
                            libro.AnioPublicacion = item.AñoPublicacion;
                            libro.Autor.IdAutor = item.Autor;
                            libro.Autor.Nombre = item.NombreAutor;
                            libro.Editorial.IdEditorial = (int)item.Editorial;
                            libro.Editorial.Nombre = item.NombreEditorial;
                        }
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Libros;
        }
        public static List<object>GetLibrosAutor(string bautor)
        {
            List<object> listaLibro = new List<object>();
            try
            {
                using (DL.LibrosContext context = new DL.LibrosContext())
                {
                    var query = (from libro in context.Libros
                                 join autor in context.Autors on libro.Autor equals autor.IdAutor
                                 join editorial in context.Editorials on libro.Editorial equals editorial.IdEditorial
                                 where autor.Nombre == bautor
                                 select new      
                                 {
                                     IdLibro = libro.IdLibro,
                                     Titulo = libro.Titulo,
                                     AñoPublicacion = libro.AñoPublicacion,
                                     Autor = libro.Autor,
                                     NombreAutor = libro.AutorNavigation.Nombre,
                                     Editorial = libro.Editorial,
                                     NombreEditorial = libro.EditorialNavigation.Nombre,
                                 });
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.Libro libro = new ML.Libro();
                            libro.Editorial = new ML.Editorial();
                            libro.Autor = new ML.Autor();
                            libro.IdLibro = item.IdLibro;
                            libro.Titulo = item.Titulo;
                            libro.AnioPublicacion = item.AñoPublicacion;
                            libro.Autor.IdAutor = item.Autor;
                            libro.Autor.Nombre = item.NombreAutor;
                            libro.Editorial.IdEditorial = (int)item.Editorial;
                            libro.Editorial.Nombre = item.NombreEditorial;
                            listaLibro.Add(libro);
                        }
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaLibro;
        }
        public static List<object> GetByTitulo(string titulo)
        {
            List<object> listaLibro = new List<object>();
            try
            {
                using (DL.LibrosContext context = new DL.LibrosContext())
                {
                    var query = (from libro in context.Libros
                                 join autor in context.Autors on libro.Autor equals autor.IdAutor
                                 join editorial in context.Editorials on libro.Editorial equals editorial.IdEditorial
                                 where libro.Titulo == titulo
                                 select new
                                 {
                                     IdLibro = libro.IdLibro,
                                     Titulo = libro.Titulo,
                                     AñoPublicacion = libro.AñoPublicacion,
                                     Autor = libro.Autor,
                                     NombreAutor = libro.AutorNavigation.Nombre,
                                     Editorial = libro.Editorial,
                                     NombreEditorial = libro.EditorialNavigation.Nombre,
                                 });
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.Libro libro = new ML.Libro();
                            libro.Editorial = new ML.Editorial();
                            libro.Autor = new ML.Autor();
                            libro.IdLibro = item.IdLibro;
                            libro.Titulo = item.Titulo;
                            libro.AnioPublicacion = item.AñoPublicacion;
                            libro.Autor.IdAutor = item.Autor;
                            libro.Autor.Nombre = item.NombreAutor;
                            libro.Editorial.IdEditorial = (int)item.Editorial;
                            libro.Editorial.Nombre = item.NombreEditorial;
                            listaLibro.Add(libro);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaLibro;
        }
        public static List<object> GetByAnio(string anio)
        {
            List<object> listaLibro = new List<object>();
            try
            {
                using (DL.LibrosContext context = new DL.LibrosContext())
                {
                    var query = (from libro in context.Libros
                                 join autor in context.Autors on libro.Autor equals autor.IdAutor
                                 join editorial in context.Editorials on libro.Editorial equals editorial.IdEditorial
                                 where libro.AñoPublicacion ==anio 
                                 select new
                                 {
                                     IdLibro = libro.IdLibro,
                                     Titulo = libro.Titulo,
                                     AñoPublicacion = libro.AñoPublicacion,
                                     Autor = libro.Autor,
                                     NombreAutor = libro.AutorNavigation.Nombre,
                                     Editorial = libro.Editorial,
                                     NombreEditorial = libro.EditorialNavigation.Nombre,
                                 });
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.Libro libro = new ML.Libro();
                            libro.Editorial = new ML.Editorial();
                            libro.Autor = new ML.Autor();
                            libro.IdLibro = item.IdLibro;
                            libro.Titulo = item.Titulo;
                            libro.AnioPublicacion = item.AñoPublicacion;
                            libro.Autor.IdAutor = item.Autor;
                            libro.Autor.Nombre = item.NombreAutor;
                            libro.Editorial.IdEditorial = (int)item.Editorial;
                            libro.Editorial.Nombre = item.NombreEditorial;
                            listaLibro.Add(libro);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaLibro;
        }
        public static bool DeleteAutor(int Idautor)
        {
            bool Correct = false;
            try
            {
                using(DL.LibrosContext context  = new DL.LibrosContext())
                {
                    var query = context.Database.ExecuteSqlRaw($"DeleteLibroAutor {Idautor}");
                    if(query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct = false;
                    }
                  
                }
            }catch (Exception ex)
            {
                Correct = false;
            }
            return Correct;
        }
        public static bool DeleteEditorial(int IdEditorial)
        {
            bool Correct = false;
            try
            {
                using(DL.LibrosContext context = new DL.LibrosContext())
                {
                    var query = context.Database.ExecuteSqlRaw($"DeleteLibroEditorial {IdEditorial}");
                    if( query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct = false;
                    }
                }
            }catch(Exception ex)
            {
                Correct=false;
            }
            return Correct;
        }
        public static bool Add(ML.Libro libro)
        {
            bool Correct = false;
            try
            {
                using(DL.LibrosContext context = new DL.LibrosContext())
                {
                    DL.Libro LibroLinq = new DL.Libro();
                    LibroLinq.Titulo = libro.Titulo;
                    LibroLinq.AñoPublicacion = libro.AnioPublicacion;
                    LibroLinq.Autor = libro.Autor.IdAutor;
                    LibroLinq.Editorial = libro.Editorial.IdEditorial;
                    context.Libros.Add(LibroLinq);
                    int query = context.SaveChanges();
                    if( query > 0 )
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct = false;
                    }
                }

            }catch(Exception ex)
            {
                Correct = false;
            }
            return Correct;
        }
    }
}
