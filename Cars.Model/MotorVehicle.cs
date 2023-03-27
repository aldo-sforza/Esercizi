namespace Cars.Model
{
    public class MotorVehicle : Vehicle
    {
        public Engine Engine { get; private set; }

        public MotorVehicle(string id)
            :base(id) 
        {
            Engine = new Engine();
        }
    }
}