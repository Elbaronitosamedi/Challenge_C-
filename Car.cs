using System;

namespace CSharpDiscovery.Quest04
{

    public class Car : Vehicule {

        public String Model {get; set;}

        public Car() {
            Model = "Unknown";
        }

        public Car (String Mod, String Brand, String Color, int Currentspeed) {
            base.Brand = Brand;
            base.Color = Color;
            base.CurrentSpeed = Currentspeed;
            Model = Mod;
        }

        public override void Accelerate(int speed) {
            if (CurrentSpeed + speed > 180){
                CurrentSpeed = 180;
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
            return (Color + " " + Brand + " " + Model);
        }
    }
}