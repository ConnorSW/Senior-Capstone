using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webmap.Models
{
    public class Amenity
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string AmenityName { get; set; }
        public virtual ICollection<ParkAmenity> ParkAmenities { get; set; }
    }
}