using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webmap.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Webmap.DAL
{
    public class ECPATContext : DbContext
    {

        public ECPATContext() : base("ECPATContext")
        {
        }

        public DbSet<Park> Parks { get; set; }
        public DbSet<ParkAmenity> ParkAmenities { get; set; }
        public DbSet<Amenity> Amenities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
