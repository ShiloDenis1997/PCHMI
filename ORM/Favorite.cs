namespace ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Favorite
    {
        public int ID { get; set; }

        public int PlaceID { get; set; }

        public int UserID { get; set; }

        public virtual Place Place { get; set; }

        public virtual User User { get; set; }
    }
}
