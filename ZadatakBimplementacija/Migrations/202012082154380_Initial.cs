namespace ZadatakBimplementacija.Migrations
{
    using System;
    using System.Data;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Proizvods",
               c => new
               {
                   id = c.Int(nullable: false, identity: true),
                   naziv = c.String(nullable: false),
                   opis = c.String(nullable: false),
                   kategorija = c.String(nullable: false),
                   cena = c.Double(nullable: false),
                   proizvođač = c.String(nullable: false),
                   dobavljač = c.String(nullable: false)
               })
               .PrimaryKey(t => t.id)
             ;
        }
        
        public override void Down()
        {
          
            DropTable("dbo.Proizvods");
        }
    }
}
