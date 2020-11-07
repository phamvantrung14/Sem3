namespace WebServiceAssigment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ContentShort = c.String(),
                        Content = c.String(),
                        Created = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Place = c.String(),
                        views = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        TypeBlogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypeBlogs", t => t.TypeBlogID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.TypeBlogID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Rate = c.Int(nullable: false),
                        Content = c.String(),
                        CustomerID = c.Int(nullable: false),
                        BlogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Blogs", t => t.BlogID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.BlogID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Created = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TypeBlogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        Descriptions = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Created = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "UserID", "dbo.Users");
            DropForeignKey("dbo.Blogs", "TypeBlogID", "dbo.TypeBlogs");
            DropForeignKey("dbo.Comments", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Comments", "BlogID", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "BlogID" });
            DropIndex("dbo.Comments", new[] { "CustomerID" });
            DropIndex("dbo.Blogs", new[] { "TypeBlogID" });
            DropIndex("dbo.Blogs", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.TypeBlogs");
            DropTable("dbo.Customers");
            DropTable("dbo.Comments");
            DropTable("dbo.Blogs");
        }
    }
}
