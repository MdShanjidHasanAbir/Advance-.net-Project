namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        FeedBackBy = c.String(maxLength: 128),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.FeedBackBy)
                .Index(t => t.FeedBackBy)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Tid = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(nullable: false),
                        TeacherDept = c.String(nullable: false),
                        FeedbackBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Tid)
                .ForeignKey("dbo.Users", t => t.FeedbackBy)
                .Index(t => t.FeedbackBy);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 20),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Uname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "FeedBackBy", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "FeedbackBy", "dbo.Users");
            DropIndex("dbo.Teachers", new[] { "FeedbackBy" });
            DropIndex("dbo.Feedbacks", new[] { "TeacherId" });
            DropIndex("dbo.Feedbacks", new[] { "FeedBackBy" });
            DropTable("dbo.Users");
            DropTable("dbo.Teachers");
            DropTable("dbo.Feedbacks");
        }
    }
}
