using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Esercizi.Models
{
    public class Engine
    {
    }

    public class Bycicle : Vehicle
    { }

    public class MotorBike : MotorVehicle
    { }

    public class Vehicle
    {
    }

    public class MotorVehicle : Vehicle
    {
        public Engine Engine { get; private set; }

        public MotorVehicle()
        {
            Engine = new Engine();
        }
    }

    //is a ==> ereditarietà
    public class Car : MotorVehicle
    {
        private Wheel[] _wheels = new Wheel[4];
        private readonly IEnumerable<Door> _doors;

        //has a ==> proprietà
        public IEnumerable<Wheel> Wheels => _wheels;

        public string Model { get; private set; }


        public Car(IEnumerable<Door> doors)
            : base()
        {
            if(doors.Count()>5)
                throw new ArgumentException();


            _doors = doors;
            _wheels[0] = new Wheel();
            _wheels[1] = new Wheel();
            _wheels[2] = new Wheel();
            _wheels[3] = new Wheel();

        }
    }
   

    public class Door
    {
    }

    public class Wheel
    {
    }

    //is a ==> ereditarietà

    public class SUV : Car
    { }
}