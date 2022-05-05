using System;
using CSharpDiscovery.Quest03;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest {
        public Double Latitude {get; set;}

        public Double Longitude {get; set;}
        public String Name {get;set;}
        public static String GoogleMapsUrlTemplate {get;set;} = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";



        public PointOfInterest() {
            Latitude = 44.854186;
            Longitude = -0.5663056;
            Name = "Bordeaux Ynov Campus";
        }

        public PointOfInterest(string Nam, Double Lat, Double Long){
                Name = Nam;
                Latitude = Lat;
                Longitude = Long;

        }

        public String GetGoogleMapsUrl(){
            String result = GoogleMapsUrlTemplate;
            result = result.Replace("{0}", Name.Replace(' ', '+'));
            result = result.Replace("{1}", Latitude.ToString());
            result = result.Replace("{2}", Longitude.ToString());
            return result;
        }


        public override String ToString(){
            return Name + " (Lat=" + Latitude + ", Long=" + Longitude +")";
        }

        public int GetDistance(PointOfInterest other)
                {
                    const int R = 6371000;
                    Double lrad1 = Latitude * Math.PI/180;
                    Double lrad2 = other.Latitude * Math.PI/180;
                    Double la = (other.Latitude-Latitude) * Math.PI/180;
                    Double lo = (other.Longitude-Longitude) * Math.PI/180;

                    Double a = Math.Sin(la/2) * Math.Sin(la/2) + Math.Cos(lrad1) * Math.Cos(lrad2) * Math.Sin(lo/2) * Math.Sin(lo/2);

                    Double c = 2 * Math.Atan2(Math.Sqrt(a),Math.Sqrt(1-a));

                    return (int)Math.Round(R * c / 1000);
                }
        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
             const int R = 6371000;
            Double lrad1 = p1.Latitude * Math.PI/180;
            Double lrad2 = p2.Latitude * Math.PI/180;
            Double la = (p2.Latitude-p1.Latitude) * Math.PI/180;
            Double lo = (p2.Longitude-p1.Longitude) * Math.PI/180;

            Double a = Math.Sin(la/2) * Math.Sin(la/2) + Math.Cos(lrad1) * Math.Cos(lrad2) * Math.Sin(lo/2) * Math.Sin(lo/2);

            Double c = 2 * Math.Atan2(Math.Sqrt(a),Math.Sqrt(1-a));

            return (int)Math.Round(R * c / 1000);
        }
    }


}


