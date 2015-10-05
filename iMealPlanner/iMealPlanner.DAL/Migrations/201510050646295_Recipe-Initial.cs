namespace iMealPlanner.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecipeInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        RecipeId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        RecipeUrl = c.String(),
                        Instructions = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.RecipeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recipes");
        }
    }
}
