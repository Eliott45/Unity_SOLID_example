using System;

namespace Dependency_Inversion_Principle
{
    class Spendable : FallingObject, IAggregateByWorth, IAggregateByConsumable
    {
        public float Worth { get; set; }

        public float GetWorth()
        {
            return Worth;
        }

        public bool IsConsumable { get; set; }

        public bool GetConsumable()
        {
            return IsConsumable;
        }

        private void Awake()
        {
            var random = new Random();

            Worth = (float) random.NextDouble() * 5;
            IsConsumable = Convert.ToBoolean(new Random().Next(0, 2));
        }
    }
}