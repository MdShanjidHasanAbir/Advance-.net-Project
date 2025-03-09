namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcatagory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedbackCatagories",
                c => new
                    {
                        CId = c.Int(nullable: false, identity: true),
                        CName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.CId);
            
            AddColumn("dbo.Feedbacks", "Catagory", c => c.String());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Feedbacks", "Catagory");
            DropTable("dbo.FeedbackCatagories");
        }
    }
}
