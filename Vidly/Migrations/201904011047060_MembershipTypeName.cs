namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("update MembershipTypes set name = 'Pay as you go' where id = 1");
            Sql("update MembershipTypes set name = 'Monthly' where id = 2");
            Sql("update MembershipTypes set name = 'Quarterly' where id = 3");
            Sql("update MembershipTypes set name = 'Yearly' where id = 4");

        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
