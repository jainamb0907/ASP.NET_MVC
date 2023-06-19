namespace Practical_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secound : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
        }
    }
}
