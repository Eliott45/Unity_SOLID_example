namespace Interface_Segregation
{
    /// <summary>
    /// Bad interface.
    /// </summary>
    internal interface IPickableItem
    {
        void Pickup();
        void Throw();
        void Crunch();
        void Kick();
        void Flame();
    }
}