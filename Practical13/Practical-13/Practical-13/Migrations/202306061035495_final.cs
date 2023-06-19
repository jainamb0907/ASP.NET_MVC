namespace Practical_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.user", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.user", "MiddleName", c => c.String(maxLength: 50));
            AlterColumn("dbo.user", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.user", "Address", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.user", "Address", c => c.String());
            AlterColumn("dbo.user", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.user", "MiddleName", c => c.String());
            AlterColumn("dbo.user", "FirstName", c => c.String(nullable: false));
        }
    }
}
