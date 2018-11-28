namespace Figuritas.Migrations
{
    using Figuritas.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Figuritas.Models.GeneralDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Figuritas.Models.GeneralDBContext";
        }

        protected override void Seed(Figuritas.Models.GeneralDBContext context)
        {

            var album = new List<Album>
            {
                new Album { Id = "a001", Nombre = "Album1"},
                new Album { Id = "a002", Nombre = "Album2"},
            };
            album.ForEach(s => context.Albumes.AddOrUpdate(p => p.Id, s));
            context.SaveChanges();


            var usuario = new List<Usuario>
            {
                new Usuario { Email = "usuario1@hotmail.com", Nombre = "Usuario1", Contrasena = "p12345678", CodAmigo = "usuario2@hotmail.com", IdAlbum = "a001"},
                new Usuario { Email = "usuario2@hotmail.com", Nombre = "Usuario2", Contrasena = "p12345678", CodAmigo = "usuario1@hotmail.com", IdAlbum = "a002"},
            };
            usuario.ForEach(s => context.Usuarios.AddOrUpdate(p => p.Email, s));
            context.SaveChanges();


            var figurita = new List<Figurita>
            {
                new Figurita { IdAlbum = "a001", Numero = 1, Cantidad = 4},
                new Figurita { IdAlbum = "a001", Numero = 2, Cantidad = 4},
                new Figurita { IdAlbum = "a001", Numero = 3, Cantidad = 4},
                new Figurita { IdAlbum = "a001", Numero = 4, Cantidad = 4},
                new Figurita { IdAlbum = "a002", Numero = 1, Cantidad = 0},
                new Figurita { IdAlbum = "a002", Numero = 2, Cantidad = 1},
                new Figurita { IdAlbum = "a002", Numero = 3, Cantidad = 2},
            };
            figurita.ForEach(s => context.Figuritas.AddOrUpdate(p => p.IdAlbum, s));
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
