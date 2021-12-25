using UnityEngine;

namespace Interface_Segregation
{
    public class Rock : MonoBehaviour, ICrunch
    {
        public KeyCode key;

        private void Update()
        {
            if (Input.GetKeyDown(key))
            {
                Crunch();
            }
        }
        
        public void Crunch()
        {
            Destroy(gameObject);
        }
    }
}