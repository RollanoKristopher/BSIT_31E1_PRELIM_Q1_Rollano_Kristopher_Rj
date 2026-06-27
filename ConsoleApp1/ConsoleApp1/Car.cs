namespace TransportChallenge
{
    public class Car : Vehicle, IDriveable
    {
        public void Drive()
        {
            // Driving behavior
        }

        public override string Move()
        {
            return "Driving on the road.";
        }
    }
}