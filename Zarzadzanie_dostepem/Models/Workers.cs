namespace Zarzadzanie_dostepem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Workers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Surname { get; set; }

        [Required]
        [StringLength(20)]
        public string Position { get; set; }

        public int Age { get; set; }

        [Column(TypeName = "money")]
        public decimal? Money { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birth_date { get; set; }

        public byte[] Photo { get; set; }
    }
}
