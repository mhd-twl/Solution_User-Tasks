namespace Solu_Tasks.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name ="Date Created")]
        public DateTime dateCreated { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime dateUpdated { get; set; }
    }
}
