using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Webmap.Models
{
    public class Park
    {
        public int ID { get; set; }
        public int pID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Street_1 { get; set; }
    
        public string City { get; set; }
        public int Postal { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public virtual ICollection<ParkAmenity> ParkAmenities { get; set; }
    }
}


