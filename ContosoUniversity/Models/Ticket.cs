using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ContosoUniversity.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime Date { get; set; }
        public int amount { get; set; }
    }

    public class TicketDbContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
    }
}