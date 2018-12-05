namespace Figuritas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Figuritas",
                c => new
                    {
                        IdAlbum = c.String(nullable: false, maxLength: 128),
                        Numero = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Album_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.IdAlbum, t.Numero })
                .ForeignKey("dbo.Albums", t => t.Album_Id)
                .Index(t => t.Album_Id);
            
            CreateTable(
                "dbo.PropuestaIntercambios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ofertante = c.String(),
                        ReceptorOferta = c.String(),
                        IdAlbum = c.String(),
                        NumeroFigurita = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                        Contrasena = c.String(nullable: false, maxLength: 15),
                        CodAmigo = c.String(),
                        IdAlbum = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Figuritas", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Figuritas", new[] { "Album_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.PropuestaIntercambios");
            DropTable("dbo.Figuritas");
            DropTable("dbo.Albums");
        }
    }
}
