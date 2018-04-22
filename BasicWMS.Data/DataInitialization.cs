using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Model;

namespace BasicWMS.Data
{
    class DataInitialization : DropCreateDatabaseAlways<BasicWmsContext>
    {
        protected override void Seed(BasicWmsContext context)
        {
            var categories = new List<Category>
            {
                new Category()
                {
                    Nombre = "Varios"
                },
                new Category()
                {
                    Nombre = "Inflamables"
                },
                new Category()
                {
                    Nombre = "Controlados"
                },
                new Category()
                {
                    Nombre = "Demandados"
                }
            };

            categories.ForEach(c => context.CategorySet.Add(c));

            var products = new List<Product>
            {
                new Product()
                {
                    Codigo = "SL2367",
                    Nombre = "Escobas",
                    CantidadDisponible = 25,
                    CantidadMinima = 5,
                    Descripcion = "Escobas de plastico",
                    Categoria = categories[0],
                    CategoriaId = categories[0].Id
                },
                new Product()
                {
                    Codigo = "SA2635",
                    Nombre = "Sillas",
                    CantidadDisponible = 235,
                    CantidadMinima = 50,
                    Descripcion = "Sillas negras de aula",
                    Categoria = categories[3],
                    CategoriaId = categories[3].Id
                },
                new Product()
                {
                    Codigo = "RT1297",
                    Nombre = "Guantes",
                    CantidadDisponible = 24,
                    CantidadMinima = 100,
                    Descripcion = "Guantes para trabajar",
                    Categoria = categories[3],
                    CategoriaId = categories[3].Id
                },
                new Product()
                {
                    Codigo = "DL1191",
                    Nombre = "Sombreros",
                    CantidadDisponible = 12,
                    CantidadMinima = 1,
                    Descripcion = "Sombreros para trabajar",
                    Categoria = categories[3],
                    CategoriaId = categories[3].Id
                },
                new Product()
                {
                    Codigo = "XC2378",
                    Nombre = "Televisores",
                    CantidadDisponible = 0,
                    CantidadMinima = 3,
                    Descripcion = "TV Haier",
                    Categoria = categories[2],
                    CategoriaId = categories[2].Id
                },
                new Product()
                {
                    Codigo = "TS2286",
                    Nombre = "Gasolina",
                    CantidadDisponible = 25,
                    CantidadMinima = 50,
                    Descripcion = "Gasolina regular",
                    Categoria = categories[1],
                    CategoriaId = categories[1].Id
                },
                new Product()
                {
                    Codigo = "GH7625",
                    Nombre = "Fuentes",
                    CantidadDisponible = 5,
                    CantidadMinima = 2,
                    Descripcion = "Fuentes conmutadas de PC",
                    Categoria = categories[2],
                    CategoriaId = categories[2].Id
                },
                new Product()
                {
                    Codigo = "YT7119",
                    Nombre = "Bocinas",
                    CantidadDisponible = 10,
                    CantidadMinima = 5,
                    Descripcion = "Bocinas de PC",
                    Categoria = categories[2],
                    CategoriaId = categories[2].Id
                },
                new Product()
                {
                    Codigo = "KO0986",
                    Nombre = "Impresoras",
                    CantidadDisponible = 7,
                    CantidadMinima = 2,
                    Descripcion = "Impresoras láser",
                    Categoria = categories[2],
                    CategoriaId = categories[2].Id
                },
                new Product()
                {
                    Codigo = "XF3385",
                    Nombre = "Pizarras",
                    CantidadDisponible = 15,
                    CantidadMinima = 5,
                    Descripcion = "Pizarras blancas de aula",
                    Categoria = categories[3],
                    CategoriaId = categories[3].Id
                },
                new Product()
                {
                    Codigo = "ER5512",
                    Nombre = "Machetes",
                    CantidadDisponible = 622,
                    CantidadMinima = 5,
                    Descripcion = "Machetes para la agricultura",
                    Categoria = categories[0],
                    CategoriaId = categories[0].Id
                },
                new Product()
                {
                    Codigo = "OJ9182",
                    Nombre = "Libretas",
                    CantidadDisponible = 1056,
                    CantidadMinima = 300,
                    Descripcion = "Libretas para la docencia",
                    Categoria = categories[3],
                    CategoriaId = categories[3].Id
                }
            };

            products.ForEach(p => context.ProductSet.Add(p));

            context.Commit();
            base.Seed(context);
        }
    }
}
