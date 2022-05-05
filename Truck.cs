using System;

namespace CSharpDiscovery.Quest04
{

    public class Truck : Vehicule {

        public int Tonnage {get; set;}

        public Truck() {
            Tonnage = 0;
        }

        public Truck (int Ton, String Brand, String Color, int Currentspeed) {
            base.Brand = Brand;
            base.Color = Color;
            base.CurrentSpeed = Currentspeed;
            Tonnage = Ton;
        }

        public override void Accelerate(int speed) {
            if (CurrentSpeed + speed > 100){
                CurrentSpeed = 100;
            } else {
                CurrentSpeed += speed;
            }
        }

        public override void Brake(int brakePow) {
            if (CurrentSpeed - brakePow < 0){
                CurrentSpeed = 0;
            } else {
                CurrentSpeed -= brakePow;
            }
        }

        public override string ToString()
        {
            return (Color + " " + Brand + " " + Tonnage + "T Truck");
        }
    }
}