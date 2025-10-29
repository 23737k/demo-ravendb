using System;
using Raven.Client.Documents;

class Program
{
    static void Main()
    {
        var store = new DocumentStore
        {
            Urls = new[] { "http://localhost:8080" },
            Database = "testing"
        }.Initialize();

        using (var session = store.OpenSession())
        {
            // Método 1: Eliminar por objeto cargado
            var estudiante = session.Load<Estudiante>("estudiantes/1-A");
            session.Delete(estudiante);

            // Método 2: Eliminar directamente por ID
            session.Delete("estudiantes/2-A");
            session.SaveChanges();
        }
    }
}

internal class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set; }
    public string[] Materias { get; set; }
}



/*
                       var estudiante = new Estudiante
                       {
                           Nombre = "María González",
                           Edad = 22,
                           Carrera = "Ingeniería en Sistemas",
                           Materias = new[] { "Base de Datos", "Algoritmos", "Redes" }
                       };

                       session.Store(estudiante);
                       session.SaveChanges();
           */