using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContext context)
        {
            context.Database.EnsureCreated();
            //buscar si exiten Registros en la Tabla Categoria
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            { new Categoria{ Nombre = "Programacion", Descripcion="Curso de Programacion", Estado=true},
            new Categoria{ Nombre = "Diseño", Descripcion="Curso de Diseño Grafico", Estado=true},
            new Categoria{ Nombre = "Idioma", Descripcion="Curso de Ingles", Estado=true}
            };

            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);

            }
            context.SaveChanges();
        }
    }
}
