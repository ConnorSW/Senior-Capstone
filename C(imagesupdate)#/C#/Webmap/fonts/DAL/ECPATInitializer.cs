using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Webmap.Models;

namespace Webmap.DAL
{

    public class ECPATInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ECPATContext>
    {
        protected override void Seed(ECPATContext context)
        {
            var parks = new List<Park>
            {
                new Park{ pID=13, Name="A.L. Williams Park" , Desc= "Mini Park Passive - 0.90 acres", Lat=   33.485030, Lng= -81.995356, Street_1="   1850 Broad St",  City=" Augusta", Postal=  30904,  Country="US", State="GA"},
                new Park{ pID=14, Name="Eastview Park", Desc="Neighborhood Park Active 4.61", Lat= 33.456664, Lng= -81.936189, Street_1=" 644 Aiken St.",  City=" Augusta", Postal=30901,  Country="US", State="GA"},
                new Park{ pID=15, Name="Riverfront Marina", Desc="4.96 acres", Lat= 33.476740, Lng= -81.959981, Street_1=" 1 Fifth Street",  City=" Augusta", Postal= 30901,  Country="US", State="GA"},
                new Park{ pID=16, Name="Riverwalk Augusta", Desc="9.75 acres", Lat= 33.476740, Lng= -81.959981, Street_1=" 1 6th Street",  City="  Augusta", Postal= 30901,  Country="US", State="GA"},
                new Park{ pID=17, Name="Augusta Common", Desc="2.07", Lat= 33.476375, Lng=   -81.965971, Street_1=" 836 Reynolds St.",  City="  August", Postal= 30901,  Country="US", State="GA"},
                new Park{ pID=18, Name="May Park", Desc="11.89 acres", Lat=  33.465496, Lng= -81.951070, Street_1=" 622 4th Street",  City=" Augusta", Postal=30901,  Country="US", State="GA"},
                new Park{ pID=19, Name="Dyess Park", Desc="7.14", Lat= 33.467171, Lng= -81.971780, Street_1=" 902 James Brown Blvd.",  City=" Augusta", Postal= 30901,  Country="US", State="GA"},
                new Park{ pID=20, Name="W.T Johnson Community Center", Desc="3.49", Lat= 33.461857, Lng= -81.991828, Street_1=" 1606 Hunter St.",  City="   Augusta", Postal=30901,  Country="US", State="GA"},
                new Park{ pID=21, Name="Jones Pool", Desc=".46", Lat=    33.457387, Lng= -81.990289, Street_1=" 1617 Holley St. ",  City=" Augusta", Postal=30901,  Country="US", State="GA"  },
                new Park{ pID=22, Name="Carrie J Mays Park", Desc="11.38", Lat= 34.448314, Lng= -81.995042, Street_1=" 1014 11th Ave.",  City="    Augusta", Postal=30901,  Country="US", State="GA"  },
                new Park{ pID=23, Name="Doughty Park", Desc="2.79 acres", Lat= 33.444860, Lng= -82.003904, Street_1=" 1200 Nellieville Rd.",  City="Augusta", Postal=30901,  Country="US", State="GA"  },
                new Park{ pID=24, Name="Hyde Park", Desc="4.78 acres", Lat= 33.435614, Lng= -81.989908, Street_1=" 2020 Leona St.",  City="Augusta", Postal=30901,  Country="US", State="GA"  },
                new Park{ pID=25, Name="Apple Valley Park", Desc="6.88", Lat= 33.393737, Lng= -81.998336, Street_1=" 1725 Marvin Griffin Rd.",  City="   Augusta", Postal=30906,  Country="US", State="GA"  },
                new Park{ pID=26, Name="Butler Creek", Desc="35.76 acres", Lat= 33.382660, Lng= -82.006138, Street_1="  2463 Carmichael Rd.",  City=" Augusta", Postal=30906,  Country="US", State="GA"  },
                new Park{ pID=27, Name="Lock and Dam Park", Desc="38.64", Lat= 33.373421, Lng= -81.938042, Street_1=" 1853 Lock and Dam Road  ",  City=" Augusta", Postal=30906,  Country="US", State="GA"  },
                new Park{ pID=28, Name="Eisenhower Park", Desc="26.10", Lat= 33.516230, Lng= -82.008405, Street_1=" 1488 Eisenhower Drive   ",  City=" Augusta", Postal=30904,  Country="US", State="GA"  },
                new Park{ pID=29, Name="Bedford Heights Park", Desc="1.87", Lat= 33.480775, Lng= -82.061881, Street_1=" 1016 Camellia Drive",  City=" Augusta", Postal=30904,  Country="US", State="GA"  },
                new Park{ pID=30, Name="West Vineland Park Rd.", Desc="1.04", Lat= 33.497940, Lng= -82.015887, Street_1=" 239 West Vineland",  City=" Augusta", Postal=30904,  Country="US", State="GA"  },
                new Park{ pID=31, Name="Lake Olmsted Park", Desc="96.83 acres", Lat= 33.490614, Lng= -82.007125, Street_1=" 2200 Broad St.",  City=" Augusta", Postal=30904,  Country="US", State="GA"  },
                new Park{ pID=32, Name="Wood Street Park", Desc="7.60 acres", Lat= 33.487670, Lng= -82.002841, Street_1=" 200 Wood St.",  City="  Augusta", Postal=30904,  Country="US", State="GA"  },
                new Park{ pID=33, Name="Hillside Park", Desc="1.43", Lat= 33.485114, Lng= -82.004605, Street_1=" 2101 Telfair St.",  City=" Augusta", Postal= 30904,  Country="US", State="GA"  },
                new Park{ pID=34, Name="Central Park", Desc="3.11 acres", Lat= 33.471200, Lng= -82.001146, Street_1=" 1130 Merry St.",  City=" Augusta", Postal= 30904,  Country="US", State="GA"  },
                new Park{ pID=35, Name="Hickman Park", Desc="1.55", Lat= 33.473578, Lng= -82.010985, Street_1=" 965 Hickman Road",  City=" Augusta", Postal= 30904,  Country="US", State="GA"  },
                new Park{ pID=36, Name="Pendleton King Park", Desc="63.90", Lat= 33.461990, Lng= -82.015495, Street_1=" 1600 Troupe St. ",  City=" Augusta", Postal= 30904,  Country="US", State="GA"  },
                new Park{ pID=37, Name="Minnick Park", Desc="3.71", Lat=33.450145 , Lng= -82.022989, Street_1=" 1850 Kissingbower Rd.",  City=" Augusta", Postal= 30904,  Country="US", State="GA"  },
                new Park{ pID=38, Name="Fleming Tennis Center", Desc="17.70 acres", Lat= 33.423449 , Lng= -82.010422, Street_1=" 1850 Chester Ave.",  City=" Augusta", Postal= 30906, Country="US", State="GA"  },
                new Park{ pID=39 , Name="Fleming Athletics Complex and Office", Desc="21.43", Lat= 33.418069, Lng= -82.014844, Street_1=" 1915 Lumpkin Rd.",  City=" Augusta", Postal= 30906 ,  Country="US", State="GA"  },
                new Park{ pID=40 , Name="Elliott Park", Desc="0.96", Lat= 33.419318, Lng= -82.020209, Street_1=" 2027 Lumpkin Rd.",  City=" Augusta", Postal= 30906, Country="US", State="GA"  },
                new Park{ pID=41 , Name="Brookfield Park", Desc="6.42 acres", Lat= 33.521403, Lng= -82.054856, Street_1=" 2740 Mayo Rd.",  City=" Augusta", Postal=  30907, Country="US", State="GA"  },
                new Park{ pID=42 , Name="Warren Road Park", Desc="9.43 acres", Lat= 33.506222, Lng= -82.057718, Street_1=" 300 Warren Rd.  ",  City=" Augusta", Postal=  30907, Country="US", State="GA"  },
                new Park{ pID=43 , Name="Big Oak Park", Desc="2.47 acres", Lat= 33.486095, Lng= -82.035872, Street_1=" 2803 Wheeler Road",  City=" Augusta", Postal= 30909, Country="US", State="GA"  },
                new Park{ pID=44 , Name="Alexander Barrett Park", Desc=".11", Lat= 33.484650, Lng= -82.028164, Street_1=" 2629 Royal St.",  City=" Augusta", Postal= 30904, Country="US", State="GA"  },
                new Park{ pID=45 , Name="Robert Blount Park", Desc="2.83 acres", Lat= 33.485830, Lng= -82.024997, Street_1="  2510 Allen St.",  City=" Augusta", Postal= 30904, Country="US", State="GA"  },
                new Park{ pID=46 , Name="Sand Hills Park", Desc="2.63", Lat= 33.483043, Lng= -82.023990, Street_1=" 2540 Wheeler Rd.",  City=" Augusta", Postal= 30904, Country="US", State="GA"  },
                new Park{ pID=47 , Name="Wood Park", Desc="3.30 Acres", Lat= 33.463644, Lng= -82.036615, Street_1=" 1866 Highland Avenue",  City=" Augusta", Postal= 30904, Country="US", State="GA"  },
                new Park{ pID=48 , Name="Augusta Golf Course", Desc="128.21", Lat= 33.461332, Lng= -82.045443, Street_1=" 2023 Highland Avenue",  City=" Augusta", Postal= 30904, Country="US", State="GA"  },
                new Park{ pID=49 , Name="Newman Tennis Center", Desc="7.82", Lat= 33.471290, Lng= -82.048027, Street_1=" 3103 Wrightsboro Rd.",  City=" Augusta", Postal= 30909,  Country="US", State="GA"  },
                new Park{ pID=50 , Name="Valley Park", Desc="1.52 33.467620", Lat= 33.467620, Lng= -82.058317, Street_1=" 1805 East Valley Park",  City=" Augusta", Postal= 30909,  Country="US", State="GA"  },
                new Park{ pID=51 , Name="Tanglewood Park", Desc="0.42 acres", Lat= 33.473428, Lng= -82.070009, Street_1=" 3300 Tanglewood Dr.",  City=" Augusta", Postal= 30909,  Country="US", State="GA"  },
                new Park{ pID=52 , Name="Augusta Soccer Park", Desc="29.80 acres", Lat= 33.480044, Lng= -82.116035, Street_1=" 3824 Maddox Rd. ",  City=" Augusta", Postal= 30909,  Country="US", State="GA"  },
                new Park{ pID=53 , Name="Sue Reynolds Park", Desc="8.88 acres", Lat= 33.475268, Lng= -82.120852, Street_1=" 1345 Community Park Rd. ",  City=" Augusta", Postal= 30909,  Country="US", State="GA"  },
                new Park{ pID=54 , Name="M.M Scott Park", Desc="11.09 acres", Lat= 33.452461, Lng= -82.126965, Street_1=" 1575 Flagler Rd.",  City=" Augusta", Postal= 30909,  Country="US", State="GA"  },
                new Park{ pID=55 , Name="H.H. Brigham Park", Desc="11.47 acres", Lat= 33.430059, Lng= -82.051742, Street_1=" 2463 Golden Camp Road",  City=" Augusta", Postal= 30906,  Country="US", State="GA"  },
                new Park{ pID=56 , Name="Bayvale Park", Desc="12.82", Lat= 33.443059, Lng= -82.070910, Street_1=" 3470 Milledgeville Rd.",  City="  Augusta", Postal= 30909,  Country="US", State="GA"  },
                new Park{ pID=57 , Name="McDuffie Woods Park", Desc="11.77", Lat= 33.429736, Lng= -82.089383, Street_1=" 3431 Old McDuffie",  City=" Augusta", Postal= 30906,  Country="US", State="GA"  },
                new Park{ pID=58 , Name="Woodlake Park", Desc="5.2", Lat= 33.392760, Lng= -82.074316, Street_1=" 2622 Crosscreek Rd.",  City=" Hephzibah", Postal= 30815,  Country="US", State="GA"  },
                new Park{ pID=59 , Name="Jamestown Community Center", Desc="5.36", Lat= 33.388180, Lng= -82.118475, Street_1=" 3647 Karleen Rd.",  City=" Hephzibah", Postal= 30815,  Country="US", State="GA"  },
                new Park{ pID=60 , Name="McBean Park", Desc="21.46 acres", Lat= 33.255266, Lng= -81.968634, Street_1=" 1155 Hephzibah/McBean Rd.",  City=" Hephzibah", Postal= 30815,  Country="US", State="GA"  },
                new Park{ pID=61 , Name="Blythe Community Park", Desc="34.89", Lat= 33.316272, Lng= -82.167466, Street_1=" 3129 HWY 88/Blythe",  City=" Hephzibah", Postal= 30805,  Country="US", State="GA"  },
                new Park{ pID=62 , Name="Meadowbrook Park", Desc="11.78 acres", Lat= 33.404624, Lng= -82.075069, Street_1=" 3638 Meadowlark Rd",  City=" Augusta", Postal= 30906,  Country="US", State="GA"  },
                new Park{ pID=63, Name="Diamond Lakes", Desc="286.13", Lat=33.353599, Lng= -82.090413, Street_1=" 4335 Windsor Springs",  City=" Hephzibah", Postal= 30815,  Country="US", State="GA"  },
                new Park{ pID=64, Name="Booking Road Park", Desc="2.3 acres", Lat= 33.362824, Lng= -82.066076, Street_1=" 2345 Boykin Rd",  City=" Augusta", Postal= 30906,  Country="US", State="GA"  },
                new Park{ pID=65, Name="Grace wood Park",Desc="6.84", Lat= 33.374988, Lng= -82.038936, Street_1=" 2309 Tobacco Rd",  City=" Augusta", Postal= 30906,  Country="US", State="GA"  },
                new Park{ pID=74, Name="	Harlem City Park",Desc="	community park with baseball fields", Lat=  33.413072, Lng= -82.320812, Street_1="		385 West Church Street, Harlem GA 30812",  City="	Harlem", Postal=    30814   ,  Country="US", State="GA"  },
                new Park{ pID=75, Name="	Keeling Test Park",Desc="	neighborhood park in Stratford subdivision. ", Lat= 33.586805, Lng= -82.151028, Street_1="		432 Keeling Lane, Evans GA 30809",  City="Evans", Postal=   30809   ,  Country="US", State="GA"  },
                new Park{ pID=76, Name="	Lonnie Morris Sr. Park",Desc="	community park with ballfields", Lat=   33.551107, Lng= -82.314621, Street_1="		2531 Appling Harlem Hwy,, Appling GA 30802",  City="Appling", Postal=   30802   ,  Country="US", State="GA"  },
                new Park{ pID=77, Name="	Patriots Park",Desc="	Large park complex with soccer, baseball, and football fields, tennis courts, playground and indoor gym with basketball and racquetball courts.", Lat=  33.520129, Lng= -82.229513, Street_1="		5445 Columbia Road",  City=" Grovetown", Postal= 30813,  Country="US", State="GA"  },
                new Park{ pID=78, Name="	Evans Town Center Park",Desc="	large complex with open fields, playgrounds, splash pad and amphitheater", Lat= 33.542612, Lng= -82.132753, Street_1="		7016 Evans Town Center Blvd",  City=" Evans", Postal=30809,  Country="US", State="GA"  },
                new Park{ pID=79, Name="	Evans Town Center Dog Park",Desc="	Dog activity park adjacent to main community park", Lat=    33.542039, Lng= -82.129444, Street_1="		7016 Evans Town Center Blvd",  City=" Evans", Postal=30809,  Country="US", State="GA"  },
                new Park{ pID=80, Name="	Columbia County Amphitheater Park",Desc="	Multi-use park with playgrounds splash pad, walking trail around a pond and amphitheater", Lat= 33.547313, Lng= -82.133949, Street_1="7022 Evans Town Center Blvd",  City="Evans", Postal=30809,  Country="US", State="GA"  },
                new Park{ pID=81, Name="	Wildwood Park",Desc="Lakefront multi-use park with playground, fields, boat launches and beach areas.", Lat= 33.646241, Lng= -82.289031, Street_1="3780 Dogwood Lane",  City="Appling", Postal=30802,  Country="US", State="GA"  },
                new Park{ pID=82, Name="	International Disc Golf Association Park",Desc="Disk Golf Course at Wildwood Park", Lat= 33.647262, Lng= -82.282266, Street_1="3780 Dogwood Lane",  City="Appling", Postal=30802,  Country="US", State="GA"  },
                new Park{ pID=83, Name="	Blanchard Woods Park",Desc="Multi-use park with playgrounds, soccer fields, BMX bike course and cross country trails", Lat= 33.554362, Lng= -82.173395, Street_1="		4600 Blanchard Woods Road",  City="Evans", Postal=  30809,  Country="US", State="GA"  },
                new Park{ pID=84, Name="	Riverside Park",Desc="	Multi-use park with playground, baseball fields and boat launch", Lat=  33.579807, Lng= -82.132913, Street_1="4432 Hardy McManus Road",  City=" Evans", Postal=30809,  Country="US", State="GA"  },
                new Park{ pID=85, Name="	Riverside Dog Park",Desc="	Dog Park adjacent to Riverside Park", Lat=  33.582640, Lng= -82.131518, Street_1="4431 Hardy McManus Road",  City="Evans", Postal=30809,  Country="US", State="GA"  },
                new Park{ pID=86, Name="	Reed Creek Park and Interpretive Center",Desc="	small science oriented park and nature center, with boardwalk over a wetland", Lat= 33.582640, Lng= -82.131518, Street_1="		3820 Park Lane",  City="Martinez", Postal=30907,  Country="US", State="GA"  },
                new Park{ pID=87, Name="	Goodale Park",Desc="	small community park with ballfields", Lat= 33.457120, Lng= -82.203085, Street_1="5207 Wrightsboro Road",  City="Grovetown", Postal=30813,  Country="US", State="GA"},
                new Park{ pID=88, Name="	West Dam Recreation Area",Desc="	Lakefront park with beaches, trails, activity parks and picnic areas", Lat= 33.659345, Lng=-82.208938, Street_1="		Sparrow Lane",  City=" Appling", Postal=30802,  Country="US", State="GA"  },
                new Park{ pID=89, Name="	Lake Springs Recreation Area",Desc="	Lakefront Park with picnic areas and beaches", Lat= 33.667793, Lng= -82.220397, Street_1="3900 Lake Springs Road",  City=" Appling", Postal=30802,  Country="US", State="GA"  },
                new Park{ pID=90, Name="	Mistletoe State Park", Desc="large, multi-use park with trails, playgrounds, picnic areas, interpretive center.", Lat=33.649843, Lng= -82.373218, Street_1="        3725 Mistletoe Road",  City="Appling", Postal=30802,  Country="US", State="GA"  },
                new Park{ pID=91, Name="	Euchee Creek Greenway", Desc="Recreational trail tracing Euchee Creek (partially completed as of 1/2017)", Lat= 33.457090, Lng= -82.230694, Street_1="Harlem Grovetwon Road, Grovetown", Postal=30813,  Country="US", State="GA"  },
                new Park{ pID=92, Name="	Kiddie Park", Desc="Small community park with playground only", Lat= 33.454895, Lng= -82.199658, Street_1="Old Wrightsboro Road, Grovetown GA 30813", City="Grovetown", Postal=30813,  Country="US", State="GA"  },
                new Park{ pID=93, Name="	Savannah Rapids Park", Desc = "Multi-use park with playground, picnic facilities, trails and riverfront path",  Lat = 33.549801, Lng= -82.040332, Street_1="      3300 Evans to Locks Road, Martinez", Postal= 30907,  Country="US", State="GA"  }
            };
            parks.ForEach(s => context.Parks.Add(s));
            context.SaveChanges();
            var amenities = new List<Amenity>
            {
            new Amenity{ID=1, AmenityName="Park Info Signs"},
            new Amenity{ID=2, AmenityName="Public Transit Stop"},
            new Amenity{ID=3, AmenityName="Parking"},
            new Amenity{ID=4, AmenityName="Sidewalks"},
            new Amenity{ID=5, AmenityName="Playground"},
            new Amenity{ID=6, AmenityName="Sport Field"},
            new Amenity{ID=7, AmenityName="Baseball Field"},
            new Amenity{ID=8, AmenityName="Swimming Pool"},
            new Amenity{ID=9, AmenityName="Splash Pad"},
            new Amenity{ID=10, AmenityName="Basketball Court"},
            new Amenity{ID=11, AmenityName="Tennis Court"},
            new Amenity{ID=12, AmenityName="Volleyball Court"},
            new Amenity{ID=13, AmenityName="Trail"},
            new Amenity{ID=14, AmenityName="Fitness Equipment"},
            new Amenity{ID=15, AmenityName="Skate Park"},
            new Amenity{ID=16, AmenityName="Off-leash Dog Park"},
            new Amenity{ID=17, AmenityName="Open/Green Space"},
            new Amenity{ID=18, AmenityName="Lake"},
            new Amenity{ID=19, AmenityName="Restrooms"},
            new Amenity{ID=20, AmenityName="Drinking Fountain"},
            new Amenity{ID=21, AmenityName="Benches"},
            new Amenity{ID=22, AmenityName="Picnic Tables"},
            new Amenity{ID=23, AmenityName="Trash Cans"},
            new Amenity{ID=24, AmenityName="Food/Vending Machines"},
            new Amenity{ID=25, AmenityName="Dog Waste Pick-up Bags"},
            new Amenity{ID=26, AmenityName="Lights"},
            new Amenity{ID=27, AmenityName="Emergency Devices"}
            };
            amenities.ForEach(s => context.Amenities.Add(s));
            context.SaveChanges();
            
        }
    }
}
