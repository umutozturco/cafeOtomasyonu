namespace CafeOtomasyon.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        menuAdi = c.String(maxLength: 50, unicode: false),
                        aciklama = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        menuId = c.Int(nullable: false),
                        urunKodu = c.String(maxLength: 20, unicode: false),
                        urunAdi = c.String(),
                        birimFiyati1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        birimFiyati2 = c.Int(nullable: false),
                        aciklama = c.String(),
                        tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.menuId, cascadeDelete: true)
                .Index(t => t.menuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "menuId", "dbo.Menu");
            DropIndex("dbo.Urun", new[] { "menuId" });
            DropTable("dbo.Urun");
            DropTable("dbo.Menu");
        }
    }
}
