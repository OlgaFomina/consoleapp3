namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSON")]
    public partial class PERSON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SUPPLIER_ID { get; set; }

        public int? INN { get; set; }

        public int? INSURANCE_NUMBER { get; set; }

        public int? PASSPORT_NUMBER { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
