namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANSPORTATION")]
    public partial class TRANSPORTATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANSPORTATION()
        {
            SUPPLies = new HashSet<SUPPLY>();
        }

        [Key]
        public int TRANSPORTATION_ID { get; set; }

        [StringLength(50)]
        public string TRANSPORTATION_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLY> SUPPLies { get; set; }
    }
}
