using UnityEngine;

namespace Interface_Segregation
{
    public class Apple : MonoBehaviour, IThrow
    {
        public KeyCode key;

        private void Update()
        {
            if (Input.GetKeyDown(key))
            {
                Throw();
            }
        }

        public void Throw()
        {
            GetComponent<Rigidbody2D>().AddForce((Vector2.up + Vector2.right)*500);
        }
    }
}