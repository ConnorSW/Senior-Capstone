using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Webmap.DAL;
using Webmap.Models;
using System.Net;
using System.Xml.Linq;
using System.IO;


namespace Webmap.Controllers
{
    public class ParksController : Controller
    {
        private ECPATContext db = new ECPATContext();

        // GET: Parks
         public ActionResult Index()
        {
            return View();
    }

    public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Park park = db.Parks.Find(id);
            if (park == null)
            {
                return HttpNotFound();
            }
            var prkName = park.Name;
            var pID = park.pID;
            var parkName = pID;// to get park folder
            var pathname = "~/Images/" + parkName;
            var filename = Server.MapPath(pathname);//to create physical path for server to read
            DirectoryInfo di = new DirectoryInfo(filename);//creates directory reference
            if (di.Exists)
            {
                FileInfo[] fiarray = di.GetFiles();//creates array of files in given directory reference
                ViewBag.Image1 = parkName + "/" + fiarray[0].Name;
                ViewBag.Image2 = parkName + "/" + fiarray[1].Name;
                ViewBag.Image3 = parkName + "/" + fiarray[2].Name;
            }
            return View(park);
        }
        public ActionResult ParkAmenity(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkAmenity parkAmenity = db.ParkAmenities.Find(id);
            if (parkAmenity == null)
            {
                return HttpNotFound();
            }
            return View(parkAmenity);
        }
        public ActionResult Amenity(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amenity Amenity = db.Amenities.Find(id);
            if (Amenity == null)
            {
                return HttpNotFound();
            }
            return View(Amenity);
        }
        public ActionResult GetDirections(double lat, double lng)
        {
            return Redirect(" https://www.google.com/maps?daddr=760+West+Genesee+Street+Syracuse+NY+13204");
        }
        public ActionResult Results(string SearchString, double checkbox)
        {
            var address = SearchString;
            var requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", Uri.EscapeDataString(address));
            var request = WebRequest.Create(requestUri);
            var response = request.GetResponse();
            var xdoc = XDocument.Load(response.GetResponseStream());
            
            var result = xdoc.Element("GeocodeResponse").Element("result");
            var locationElement = result.Element("geometry").Element("location");
            var lat = locationElement.Element("lat");
            var lng = locationElement.Element("lng");
            // List<Park> mathces = new List<Park>();
            var vm = new ResultsViewModel();
            var parks = db.Parks;
            ViewBag.aList = db.Amenities.OrderBy(x => x.AmenityName).ToList();
            foreach (var park in parks)
            {
                double distance = GetDistanceKM(new LatLon(lat, lng),
                                    new LatLon(park.Lat, park.Lng));
                if (distance <= checkbox)
                {
                    vm.Parks.Add(park);
                }
            }
            return View(vm);
        }
        [HttpPost]
        public ActionResult Results(ResultsViewModel m)
        {

            ViewBag.aList = db.Amenities.OrderBy(x => x.AmenityName).ToList();
            string [] k = Request.Form.GetValues("keys");
            
            List<Park> originalParks = new List<Park>();
            foreach(var i in k)
            {
                int j = Convert.ToInt32(i);
                Park park = db.Parks.Find(j);
                originalParks.Add(park);
            }
            
            List<string> amList=new List<string>();
            foreach (string x in Request.Form.Keys)
            {


                if (x != "keys")
                {
                    foreach (string y in Request.Form.GetValues(x))
                        amList.Add(y);
                }
            }
            ResultsViewModel vm = new ResultsViewModel();
            foreach (Park p in originalParks)
            {
                int amFound = 0;
                foreach (var a in amList)
                {
                    //bool found = false;
                    foreach (var an in p.ParkAmenities)
                    {

                        if (an.Amenity.AmenityName == a /*&& vm.Parks.Contains(p)==false*/)
                        {
                            amFound++;

                        }
                    }

                }
                if (amFound == amList.Count)
                {
                    vm.Parks.Add(p);
                }
            }
            return View(vm);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public struct LatLon
        {
            public double Latitude;
            public double Longtitude;
            private string Lat;
            private string Lng;
     
            
            public LatLon(double latitude, double longtitude) : this()
            {
                this.Latitude = latitude;
                this.Longtitude = longtitude;
            }

            public LatLon(XElement latitude, XElement longtitude) : this()
            {
                this.Lat = latitude.Value;
                this.Lng = longtitude.Value;
                this.Latitude = Double.Parse(this.Lat);
                this.Longtitude = Double.Parse(this.Lng);

            }
        }

        /// <summary>
        /// Radius of the Earth in Kilometers.
        /// </summary>
        private const double EARTH_RADIUS_KM = 6371;

        /// <summary>
        /// Converts an angle to a radian.
        /// </summary>
        /// <param name="input">The angle that is to be converted.</param>
        /// <returns>The angle in radians.</returns>
        private static double ToRad(double input)
        {
            return input * (Math.PI / 180);
        }

        /// <summary>
        /// Calculates the distance between two geo-points in kilometers using the Haversine algorithm.
        /// </summary>
        /// <param name="point1">The first point.</param>
        /// <param name="point2">The second point.</param>
        /// <returns>A double indicating the distance between the points in KM.</returns>
        public static double GetDistanceKM(LatLon point1, LatLon point2)
        {
            double dLat = ToRad(point2.Latitude - point1.Latitude);
            double dLon = ToRad(point2.Longtitude - point1.Longtitude);

            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Cos(ToRad(point1.Latitude)) * Math.Cos(ToRad(point2.Latitude)) *
                       Math.Pow(Math.Sin(dLon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = EARTH_RADIUS_KM * c;
            return distance;
        }
    }
}
