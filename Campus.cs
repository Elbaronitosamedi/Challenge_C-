using System;
using CSharpDiscovery.Quest03;

namespace CSharpDiscovery.Quest03 
{

    public class Campus : PointOfInterest {
        public int Capacity {get;set;}

        public override String ToString(){
                return Name + " is a campus with a capacity of " + Capacity +" students";
        }
    }


}