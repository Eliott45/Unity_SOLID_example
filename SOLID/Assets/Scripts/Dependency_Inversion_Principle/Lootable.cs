using System;

namespace Dependency_Inversion_Principle
{
    class Lootable : FallingObject, IAggregateByLootable
    {
        public bool isLootable { get; set; }
    
        public bool GetLootable()
        {
            return isLootable;
        }

        private void Awake()
        {
            var random = new Random();
            isLootable = Convert.ToBoolean(random.Next(0, 2));
        }
    }
}