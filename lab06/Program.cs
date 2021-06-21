﻿using System;

namespace lab06
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);

            thermostat.OnTemperatureChange +=
                heater.OnTemperatureChanged;
            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperatureChange +=
                heaterCuong.OnTemperatureChanged;
            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange +=
                cooler.OnTemperatureChanged;
            string temperature;
            Console.Write("Enter temperature:");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();
        }
    }
}