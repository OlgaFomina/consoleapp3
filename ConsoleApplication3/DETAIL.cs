namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DETAIL")]
    public partial class DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DETAIL()
        {
            DELIVERY_STRING = new HashSet<DELIVERY_STRING>();
            SUPPLies = new HashSet<SUPPLY>();
        }

        [Key]
        public int DETAIL_ID { get; set; }

        [StringLength(50)]
        public string DETAIL_NAME { get; set; }

        public int? MATERIAL_ID { get; set; }

        public int? DETAIL_QUANTITY { get; set; }

        public decimal? WEIGHT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DELIVERY_STRING> DELIVERY_STRING { get; set; }

        public virtual MATERIAL MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLY> SUPPLies { get; set; }
    }
}
