using UnityEngine;

namespace Interface_Segregation
{
    public class Coin : MonoBehaviour, IPickup
    {
        public KeyCode key;
        private float _timer;

        private void Update()
        {
            if (_timer > 0)
                _timer -= Time.deltaTime;

            if (Input.GetKeyDown(key))
            {
                Pickup();
                _timer = 1f;
            }

            if(_timer < 0 )
                Destroy(gameObject);
        }

        public void Pickup()
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up*800);
        }
    }
}
