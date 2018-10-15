namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUPPLIER")]
    public partial class SUPPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPPLIER()
        {
            SUPPLies = new HashSet<SUPPLY>();
        }

        [Key]
        public int SUPPLIER_ID { get; set; }

        public int? CITY_ID { get; set; }

        public int? SUPPLIER_TYPE { get; set; }

        [StringLength(150)]
        public string SUPPLIER_NAME { get; set; }

        public virtual CITY CITY { get; set; }

        public virtual ORGANIZATION ORGANIZATION { get; set; }

        public virtual PERSON PERSON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLY> SUPPLies { get; set; }
    }
}
