﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }

        public Car(int year, string make, String model, String engineNoise, String honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;   
            Model = model;  
            EngineNoise = engineNoise;  
            HonkNoise = honkNoise;  
            IsDrivable = isDrivable;    
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.Write(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

    }
}
