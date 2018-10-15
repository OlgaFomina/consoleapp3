namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DELIVERY_STRING
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DELIVERY_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STRING_ID { get; set; }

        public int? DETAIL_ID { get; set; }

        public int? DELIVERY_QUANTITY { get; set; }

        public virtual DELIVERY DELIVERY { get; set; }

        public virtual DETAIL DETAIL { get; set; }
    }
}
