using System;

namespace CSharpDiscovery.Quest04
{
    public class HybridCar:Car, IThermalCar, IElectricCar
    {
        public int FuelLevel {get;set;} = 100;
        public int BatteryLevel {get;set;} = 100;
        public HybridCar() : base(){

        }
        public HybridCar(String Mod, String Brand, String Color, int CurrentSpeed=0):base(Mod,Brand,Color,CurrentSpeed){
            this.Model = Mod;
            this.Brand = Brand;
            this.Color = Color;
            this.CurrentSpeed = CurrentSpeed;
        }

        public int GetFuelLevel(){
            return FuelLevel;
        }

        public int GetBatteryLevel(){
            return BatteryLevel;
        }

        public void FillUp(){
            FuelLevel = 100;
        }
        public void Recharge(){
            BatteryLevel = 100;
        }

        public override string ToString()
        {
            return (Color)+" "+(Brand)+" "+(Model)+", Battery: "+(BatteryLevel)+"%, Fuel: "+(FuelLevel)+"%";
        }
    }
}