using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Budget
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Amount")]
        public decimal amount { get; set; }
    }

    public class BudgetDbContext : DbContext
    {
        public DbSet<Budget> Budgets { get; set; }
    }
}