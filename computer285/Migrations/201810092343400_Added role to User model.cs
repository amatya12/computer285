namespace computer285.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedroletoUsermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Role", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Role");
        }
    }
}
