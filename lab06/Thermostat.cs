namespace lab06
{
    public class Thermostat
    {
        public delegate void TemperatureChangeHandler(
            float newTemperature);

// Define the event publisher
        private TemperatureChangeHandler _OnTemperatureChange;

        public TemperatureChangeHandler OnTemperatureChange
        {
            get { return _OnTemperatureChange; }
            set { _OnTemperatureChange = value; }
        }

        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set
            {
                if (value != CurrentTemperature)
                {
                    _CurrentTemperature = value;// Call subscribers
                    if (OnTemperatureChange != null)
                    {
                        OnTemperatureChange(value);
                    }
                }
            }
        }

        private float _CurrentTemperature;
    }
}