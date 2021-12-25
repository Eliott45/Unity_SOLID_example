using System.Linq;

namespace Liskov_Substitution
{
    public class Circle : GeoObject
    {
        private void Awake()
        {
            id = -1;
            Values = new int[] { 4, 1, 4, 1 };
        }

        public Circle(int[] values, int id) : base(values, id)
        {
        }

        public override int AdditionOfValues() => Values.Sum();
    }
}
