using System;
using Raven.Client.Documents;

class Program
{
    static void Main()
    {
        var store = new DocumentStore
        {
            Urls = new[] { "http://127.0.0.1:8080", "http://127.0.0.2:8080" },
            Database = "testing"
        }.Initialize();


        using (var session = store.OpenSession())
        {
            //--------------------------------------------------------------------------------------------------




            //--------------------------------------------------------------------------------------------------

        }
    }
}

internal class Estudiante
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set; }
    public string[] Materias { get; set; }
}





/*

CREATE

            var estudiante = new Estudiante
            {
                Id = "estudiantes/1-C",
                Nombre = "María González",
                Edad = 22,
                Carrera = "Ingeniería en Sistemas",
                Materias = new[] { "Base de Datos", "Algoritmos", "Redes" }
            };

            session.Store(estudiante);
            session.SaveChanges();
*/

/*

READ

CON LOAD:


            var estudiante = session.Load<Estudiante>("estudiantes/1-C");
            if(estudiante != null){
                Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            }

*/

/*
    UPDATE
            var estudiante = session.Load<Estudiante>("estudiantes/1-C");
            estudiante.Edad = 23;
            estudiante.Materias = estudiante.Materias.Concat(new[] { "Inteligencia Artificial" }).ToArray();

            session.SaveChanges();


*/


/*
    DELETE

            var estudiante = session.Load<Estudiante>("estudiantes/1-C");
            session.SaveChanges();
*/
