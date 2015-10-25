namespace iMealPlanner.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodeIngredientInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Codes",
                c => new
                    {
                        codeId = c.Int(nullable: false, identity: true),
                        Ref = c.String(),
                        Description = c.String(),
                        parentCodeId = c.String(),
                    })
                .PrimaryKey(t => t.codeId);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.IngredientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ingredients");
            DropTable("dbo.Codes");
        }
    }
}
