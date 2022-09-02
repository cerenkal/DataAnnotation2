namespace DataAnnotation2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ogretmen",
                c => new
                    {
                        OgretmenID = c.Int(nullable: false, identity: true),
                        OgretmenAdi = c.String(),
                        OgretmenSoyadi = c.String(),
                        Yas = c.Int(nullable: false),
                        OkulID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgretmenID)
                .ForeignKey("dbo.Okuls", t => t.OkulID, cascadeDelete: true)
                .Index(t => t.OkulID);
            
            CreateTable(
                "dbo.Sinifs",
                c => new
                    {
                        SinifID = c.Int(nullable: false, identity: true),
                        SiraSayisi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SinifID);
            
            CreateTable(
                "dbo.SinifOgretmen",
                c => new
                    {
                        Sinif_SinifID = c.Int(nullable: false),
                        Ogretmen_OgretmenID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sinif_SinifID, t.Ogretmen_OgretmenID })
                .ForeignKey("dbo.Sinifs", t => t.Sinif_SinifID, cascadeDelete: true)
                .ForeignKey("dbo.Ogretmen", t => t.Ogretmen_OgretmenID, cascadeDelete: true)
                .Index(t => t.Sinif_SinifID)
                .Index(t => t.Ogretmen_OgretmenID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinifOgretmen", "Ogretmen_OgretmenID", "dbo.Ogretmen");
            DropForeignKey("dbo.SinifOgretmen", "Sinif_SinifID", "dbo.Sinifs");
            DropForeignKey("dbo.Ogretmen", "OkulID", "dbo.Okuls");
            DropIndex("dbo.SinifOgretmen", new[] { "Ogretmen_OgretmenID" });
            DropIndex("dbo.SinifOgretmen", new[] { "Sinif_SinifID" });
            DropIndex("dbo.Ogretmen", new[] { "OkulID" });
            DropTable("dbo.SinifOgretmen");
            DropTable("dbo.Sinifs");
            DropTable("dbo.Ogretmen");
        }
    }
}
