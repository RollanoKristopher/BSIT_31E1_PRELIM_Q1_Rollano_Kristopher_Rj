namespace TransportChallenge
{
    public static class TransportResolver
    {
        public static Vehicle? Resolve(string transport)
        {
            return transport.ToLower() switch
            {
                "car" => new Car(),
                "plane" => new Airplane(),
                "boat" => new Boat(),
                "helicopter" => new Helicopter(),
                  _ => null
              };
             }
         }
    }   