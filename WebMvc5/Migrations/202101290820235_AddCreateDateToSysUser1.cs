namespace WebMvc5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreateDateToSysUser1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SysUser", "CreateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SysUser", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
