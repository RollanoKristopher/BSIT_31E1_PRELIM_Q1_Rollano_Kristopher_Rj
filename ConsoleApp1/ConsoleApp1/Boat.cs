namespace TransportChallenge
{
    public class Boat : Vehicle, ISailable
    {
        public void Sail()
        {
            // Sailing behavior
        }

        public override string Move()
        {
            return "Sailing on the water.";
        }
    }
}