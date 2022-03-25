namespace Carro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarroModels",
                c => new
                    {
                        cod = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false),
                        Cor = c.String(nullable: false),
                        Ano = c.Int(nullable: false),
                        Marca = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.cod);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarroModels");
        }
    }
}
