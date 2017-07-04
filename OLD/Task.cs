namespace Solu_Tasks.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public string description { get; set; }

        public DateTime dateCreated { get; set; }

        public DateTime dateUpdated { get; set; }
    }
}
