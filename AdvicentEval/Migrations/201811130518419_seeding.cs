namespace AdvicentEval.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeding : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colleges",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CollegeName = c.String(),
                        InStateTuition = c.Int(),
                        OutofStateTuition = c.Int(),
                        RoomAndBoard = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Colleges");
        }
    }
}
