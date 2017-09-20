using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Webmap.Models
{
    public class ParkAmenity
    {
        [Key, Column(Order =1)]
        public int ParkID { get; set; }
        [Key, Column(Order =2)]
        public int AmenityID { get; set; }


        public virtual Park Park { get; set; }
        public virtual Amenity Amenity { get; set; }
    }
}


