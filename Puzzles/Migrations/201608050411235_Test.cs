namespace Puzzles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PuzzleProducts", "Catagory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PuzzleProducts", "Catagory", c => c.String());
        }
    }
}
