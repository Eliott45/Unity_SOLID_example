using UnityEngine;
using UnityEngine.UI;

namespace Dependency_Inversion_Principle
{
    public class AggregatorConsumables : MonoBehaviour
    {
        public Text statisticText;
        public int aggAmount = 0;
        public string label = "Radar: ";

        private void OnTriggerEnter2D(Collider2D col)
        {
            CanBeCounted(col.gameObject.GetComponent<IAggregateByConsumable>() ?? null);
        }

        private void CanBeCounted(IAggregateByConsumable fallingObject)
        {
            if (fallingObject == null)
                return;
        
            if (fallingObject.GetConsumable())
                aggAmount++;
            statisticText.text = label + aggAmount;
        }
    }
}