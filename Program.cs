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
            var user = new User{
            Name= "pepe",
            City= "CABA",
            Age= 28
            };
            session.Store(user);
            session.SaveChanges();
        }

        Console.WriteLine("Documento guardado!");
    }
}
