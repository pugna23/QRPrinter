namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("qrData")]
    public partial class qrData : IPrintable
    {
        [Key]
        [StringLength(50)]
        public string EAB { get; set; }

        [StringLength(50)]
        public string Local { get; set; }

        [Required]
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Med { get; set; }

        [Required]
        [StringLength(50)]
        public string Pos { get; set; }

        public string ToQR => string.Format("{0}|{1}|{2}", EAB, Local, Med);
    }
}
