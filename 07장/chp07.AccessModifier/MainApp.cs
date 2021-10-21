using static System.Console;
using System;

namespace AccessModifier
{
    class WaterHeater
    {
        //protected로 설정되어 있어서 외부에서 바로 값변경 불가!
        //오로지 public으로 설정된 메서드를 통해 변경 가능
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            WriteLine($"Turn on water : {temperature}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();
                
                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}