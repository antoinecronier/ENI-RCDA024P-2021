namespace Module6_Demo3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artistes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artiste",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AlbumArtiste",
                c => new
                    {
                        Album_Id = c.Int(nullable: false),
                        Artiste_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Album_Id, t.Artiste_Id })
                .ForeignKey("dbo.Album", t => t.Album_Id, cascadeDelete: true)
                .ForeignKey("dbo.Artiste", t => t.Artiste_Id, cascadeDelete: true)
                .Index(t => t.Album_Id)
                .Index(t => t.Artiste_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlbumArtiste", "Artiste_Id", "dbo.Artiste");
            DropForeignKey("dbo.AlbumArtiste", "Album_Id", "dbo.Album");
            DropIndex("dbo.AlbumArtiste", new[] { "Artiste_Id" });
            DropIndex("dbo.AlbumArtiste", new[] { "Album_Id" });
            DropTable("dbo.AlbumArtiste");
            DropTable("dbo.Artiste");
        }
    }
}
