using UnityEngine;
using UnityEngine.UI;

namespace Dependency_Inversion_Principle
{
    public class AggregatorLootables : MonoBehaviour
    {
        public Text statisticText;
        public int aggAmount;
        public string label = "Radar: ";

        private void OnTriggerEnter2D(Collider2D col)
        {
            CanBeCounted(col.gameObject.GetComponent<IAggregateByLootable>()?? null);
        }

        private void CanBeCounted(IAggregateByLootable fallingObject)
        {
            if (fallingObject == null)
                return;
        
            if (fallingObject.GetLootable())
                aggAmount++;
            statisticText.text = label + aggAmount;
        }
    }
}