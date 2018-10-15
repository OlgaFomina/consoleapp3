namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DELIVERY")]
    public partial class DELIVERY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DELIVERY()
        {
            DELIVERY_STRING = new HashSet<DELIVERY_STRING>();
        }

        [Key]
        public int DELIVERY_ID { get; set; }

        public DateTime? DELIVERY_DATE { get; set; }

        public int? DEPARTMENT_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DELIVERY_STRING> DELIVERY_STRING { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }
    }
}
