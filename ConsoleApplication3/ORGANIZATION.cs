namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORGANIZATION")]
    public partial class ORGANIZATION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SUPPLIER_ID { get; set; }

        public int? OWNERSHIP_ID { get; set; }

        public int? REG_NUMBER { get; set; }

        public DateTime? REG_DATE { get; set; }

        [StringLength(150)]
        public string ADDRESS { get; set; }

        public virtual OWNERSHIP OWNERSHIP { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
