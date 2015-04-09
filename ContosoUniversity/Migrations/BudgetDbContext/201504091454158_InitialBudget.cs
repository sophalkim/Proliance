namespace ContosoUniversity.Migrations.BudgetDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialBudget : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Budgets", "amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Budgets", "amount", c => c.Int(nullable: false));
        }
    }
}
