namespace Module6_Demo3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Album",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Groupe = c.String(),
                        Annee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Piste",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Duree = c.Int(nullable: false),
                        Nom = c.String(),
                        Album_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Album", t => t.Album_Id, cascadeDelete: true)
                .Index(t => t.Album_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Piste", "Album_Id", "dbo.Album");
            DropIndex("dbo.Piste", new[] { "Album_Id" });
            DropTable("dbo.Piste");
            DropTable("dbo.Album");
        }
    }
}
