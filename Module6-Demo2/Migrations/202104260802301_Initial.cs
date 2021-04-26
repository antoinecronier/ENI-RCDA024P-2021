namespace Module6_Demo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Prenom = c.String(),
                        Nom = c.String(),
                        Adresse_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.Adresse_Id)
                .Index(t => t.Adresse_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personnes", "Adresse_Id", "dbo.Adresses");
            DropIndex("dbo.Personnes", new[] { "Adresse_Id" });
            DropTable("dbo.Roles");
            DropTable("dbo.Personnes");
            DropTable("dbo.Adresses");
        }
    }
}
