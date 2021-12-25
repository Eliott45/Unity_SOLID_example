namespace Interface_Segregation
{
    internal interface IFlame
    {
        void Flame();
    }

    internal interface ICrunch
    {
        void Crunch();
    }

    internal interface IThrow
    {
        void Throw();
    }

    internal interface IKick
    {
        void Kick();
    }

    interface IPickup
    {
        void Pickup();
    }
}