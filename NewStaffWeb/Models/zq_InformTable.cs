namespace NewStaffWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zq_InformTable
    {
        public int id { get; set; }

        [Required]
        public string inform { get; set; }
    }
}
