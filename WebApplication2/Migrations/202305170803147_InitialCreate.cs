namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        Credential = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Credential);
            
            CreateTable(
                "dbo.UserRegisters",
                c => new
                    {
                        Credential = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Credential);
            
            CreateTable(
                "dbo.DataRequests",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.zapovedniks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.zapovedniks");
            DropTable("dbo.DataRequests");
            DropTable("dbo.UserRegisters");
            DropTable("dbo.UserLogins");
        }
    }
}
