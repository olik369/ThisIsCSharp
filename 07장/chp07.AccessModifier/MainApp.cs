using System;
using static System.Console;

namespace chp07.AccessModifier
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature; //현재 온도값은 protected로 설정되어있어 외부에서 접근 불가
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

                heater.SetTemperature(50);  //42도를 초과해서 예외가 발생함
                heater.TurnOnWater();       //39행은 throw exception으로 인해 실행되지 않음
                                            //대신 catch블록으로 넘어감
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
