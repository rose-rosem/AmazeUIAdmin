namespace NewStaffWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Customer : DbContext
    {
        public Customer()
            : base("name=Customer")
        {
        }

        public virtual DbSet<zq_CustomerTable> zq_CustomerTable { get; set; }
        public virtual DbSet<zq_InformTable> zq_InformTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
