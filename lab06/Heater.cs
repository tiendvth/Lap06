namespace lab06
{
    public class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }

        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }

        private float _Temperature;

        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature < Temperature)
            {
                System.Console.WriteLine("Heater: On");
            }
            else
            {
                System.Console.WriteLine("Heater: Off");
            }
        }
    }
}