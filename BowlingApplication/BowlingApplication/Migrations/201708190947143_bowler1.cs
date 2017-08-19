namespace BowlingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bowler1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BowlingScores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Frame = c.Int(nullable: false),
                        TotalScore = c.Int(nullable: false),
                        Strikes = c.Int(nullable: false),
                        Spares = c.Int(nullable: false),
                        UID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BowlingScores");
        }
    }
}
