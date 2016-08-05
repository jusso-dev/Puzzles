namespace Puzzles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedpricetodecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PuzzleProducts", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PuzzleProducts", "Price", c => c.Single(nullable: false));
        }
    }
}
