namespace NewStaffWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zq_CustomerTable
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string customerName { get; set; }

        [Required]
        [StringLength(20)]
        public string customerPhone { get; set; }

        [StringLength(50)]
        public string customerMessage { get; set; }
    }
}
