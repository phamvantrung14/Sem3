namespace Code_First_Web_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColFirstName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "FirstMideName", newName: "First Name");
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 10));
            AlterColumn("dbo.Students", "First Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "First Name", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            RenameColumn(table: "dbo.Students", name: "First Name", newName: "FirstMideName");
        }
    }
}
