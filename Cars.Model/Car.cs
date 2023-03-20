namespace Cars.Model
{
    //is a ==> ereditarietà
    public class Car : MotorVehicle
    {
        private Wheel[] _wheels = new Wheel[4];
        private readonly IEnumerable<Door> _doors;

        //has a ==> proprietà
        public IEnumerable<Door> Doors => _doors;
        public IEnumerable<Wheel> Wheels => _wheels;

        public string Model { get; private set; }

        public Car(IEnumerable<Door> doors)
            : base()
        {
            if (doors.Count() == 0)
                throw new ArgumentException();

            if (doors.Count() > 5)
                throw new ArgumentException();

            _doors = doors;
            _wheels[0] = new Wheel();
            _wheels[1] = new Wheel();
            _wheels[2] = new Wheel();
            _wheels[3] = new Wheel();
        }
    }
}