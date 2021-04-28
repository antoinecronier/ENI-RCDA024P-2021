namespace Module6_Tp1_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Degats = c.Int(nullable: false),
                        Samourai_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Samourais", t => t.Samourai_Id)
                .Index(t => t.Samourai_Id);
            
            CreateTable(
                "dbo.ArtMartials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Samourais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Force = c.Int(nullable: false),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SamouraiArtMartials",
                c => new
                    {
                        Samourai_Id = c.Int(nullable: false),
                        ArtMartial_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Samourai_Id, t.ArtMartial_Id })
                .ForeignKey("dbo.Samourais", t => t.Samourai_Id, cascadeDelete: true)
                .ForeignKey("dbo.ArtMartials", t => t.ArtMartial_Id, cascadeDelete: true)
                .Index(t => t.Samourai_Id)
                .Index(t => t.ArtMartial_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SamouraiArtMartials", "ArtMartial_Id", "dbo.ArtMartials");
            DropForeignKey("dbo.SamouraiArtMartials", "Samourai_Id", "dbo.Samourais");
            DropForeignKey("dbo.Armes", "Samourai_Id", "dbo.Samourais");
            DropIndex("dbo.SamouraiArtMartials", new[] { "ArtMartial_Id" });
            DropIndex("dbo.SamouraiArtMartials", new[] { "Samourai_Id" });
            DropIndex("dbo.Armes", new[] { "Samourai_Id" });
            DropTable("dbo.SamouraiArtMartials");
            DropTable("dbo.Samourais");
            DropTable("dbo.ArtMartials");
            DropTable("dbo.Armes");
        }
    }
}
