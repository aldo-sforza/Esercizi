namespace Cars.Model
{
    //is a ==> ereditarietà

    public class SUV : Car
    {
        public SUV(IEnumerable<Door> doors) : base(doors)
        {
        }
    }
}