namespace Cars.Model
{
    //is a ==> ereditarietà

    public class SUV : Car
    {
        public SUV(string id,IEnumerable<Door> doors) : base(id, doors)
        {
        }
    }
}