using Microsoft.EntityFrameworkCore;
using PrimerProyectoASPConRazor.Data;

namespace PrimerProyectoASPConRazor.Models {
    public class SeedData {
        
        public static void Initialize(IServiceProvider serviceProvider) {
            using(var context = new PrimerProyectoASPConRazorContext(
                serviceProvider.GetRequiredService<DbContextOptions<PrimerProyectoASPConRazorContext>>())) {
                if(context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null PrimerProyectoASPConRazorContext");
                }

                //Revisar si existen peliculas
                if (context.Movie.Any()) {
                    return; //Significa que la tabla Movie ya contiene datos.
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Volver al Futuro",
                        ReleaseDate = DateTime.Parse("18-4-1985"),
                        Genre = "SciFi",
                        Price = 4.45M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Harry Potter y la piedra filosofal",
                        ReleaseDate = DateTime.Parse("15-7-2003"),
                        Genre = "Fantasia",
                        Price = 5.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "El señor de los anillos",
                        ReleaseDate = DateTime.Parse("22-9-2007"),
                        Genre = "Fantasia",
                        Price = 7.99M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
