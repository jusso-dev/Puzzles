namespace Puzzles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PuzzleProducts",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        TypeOfPuzzle = c.String(),
                        Catagory = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PuzzleProducts");
        }
    }
}
