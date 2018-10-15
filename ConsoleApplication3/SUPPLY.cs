namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUPPLY")]
    public partial class SUPPLY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPPLY()
        {
            TRANSPORTATIONs = new HashSet<TRANSPORTATION>();
        }

        [Key]
        public int SUPPLY_ID { get; set; }

        public DateTime? SUPPLY_DATE { get; set; }

        public int? SUPPLIER_ID { get; set; }

        public int? SUPPLY_QUANTITY { get; set; }

        public decimal? SUPPLY_COST { get; set; }

        public int? PACKING_ID { get; set; }

        public int? DETAIL_ID { get; set; }

        public virtual DETAIL DETAIL { get; set; }

        public virtual PACKING PACKING { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSPORTATION> TRANSPORTATIONs { get; set; }
    }
}
