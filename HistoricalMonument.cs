using System;
using CSharpDiscovery.Quest03;

namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest {
        public int BuildYear {get;set;}

        public HistoricalMonument(){

        }

        public HistoricalMonument(String Name, Double Latitude, Double Longitude, int BY){
            base.Name = Name;
            base.Latitude = Latitude;
            base.Longitude = Longitude;
            BuildYear = BY;
        }

        public override string ToString()
        {
            return (Name+" is a historical monument built in "+BuildYear);
        }       
    }
}