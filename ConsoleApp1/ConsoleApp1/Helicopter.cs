namespace TransportChallenge
{
    public class Helicopter : Vehicle, IFlyable, IDriveable
    {
        public void Fly()
        {
        }

        public void Drive()
        {
        }

        public override string Move()
        {
            return "Flying in the sky.";
        }
    }
}