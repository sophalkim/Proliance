namespace ContosoUniversity.Migrations.TicketDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTicket : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "amount", c => c.Int(nullable: false));
        }
    }
}
