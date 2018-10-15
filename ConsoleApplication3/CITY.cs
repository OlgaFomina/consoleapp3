namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CITY")]
    public partial class CITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CITY()
        {
            SUPPLIERs = new HashSet<SUPPLIER>();
        }

        [Key]
        public int CITY_ID { get; set; }

        [StringLength(50)]
        public string CITY_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLIER> SUPPLIERs { get; set; }
    }
}
