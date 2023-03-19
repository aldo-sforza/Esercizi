namespace Cars.Model
{
    public class MotorVehicle : Vehicle
    {
        public Engine Engine { get; private set; }

        public MotorVehicle()
        {
            Engine = new Engine();
        }
    }
}