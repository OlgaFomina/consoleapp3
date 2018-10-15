namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PACKING")]
    public partial class PACKING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACKING()
        {
            SUPPLies = new HashSet<SUPPLY>();
        }

        [Key]
        public int PACKING_ID { get; set; }

        [StringLength(20)]
        public string PACKING_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLY> SUPPLies { get; set; }
    }
}
