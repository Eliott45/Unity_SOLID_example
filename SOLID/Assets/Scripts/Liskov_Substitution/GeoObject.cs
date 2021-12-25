using UnityEngine;

namespace Liskov_Substitution
{
    public abstract  class GeoObject : MonoBehaviour
    {
        protected int[] Values;
        public int id;

        protected GeoObject(int[] values, int id)
        {
            Values = values;
            this.id = id;
        }

        public abstract int AdditionOfValues();
    }
}
