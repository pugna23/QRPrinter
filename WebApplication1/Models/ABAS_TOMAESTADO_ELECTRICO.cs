namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ABAS-TOMAESTADO ELECTRICO")]
    public partial class ABAS_TOMAESTADO_ELECTRICO
    {
        public int? OrdenEAB { get; set; }

        [StringLength(10)]
        public string NivelLocal { get; set; }

        [StringLength(100)]
        public string LocalNum { get; set; }

        [StringLength(100)]
        public string LocalNombre { get; set; }

        public int? UbicMed { get; set; }

        [StringLength(100)]
        public string Tablero { get; set; }

        public int Id { get; set; }
    }
}
