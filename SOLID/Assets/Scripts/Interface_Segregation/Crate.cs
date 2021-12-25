using UnityEngine;

namespace Interface_Segregation
{
    /// <summary>
    /// Bad guy.
    /// </summary>
    public class Crate : MonoBehaviour, IPickableItem
    {
        public KeyCode key;
        public float throttle;

        private void Update()
        {
            if (Input.GetKeyDown(key))
            {
                Kick();
            }
        }
        
        public void Pickup()
        {
            throw new System.NotImplementedException();
        }

        public void Throw()
        {
            throw new System.NotImplementedException();
        }

        public void Crunch()
        {
            throw new System.NotImplementedException();
        }

        public void Kick()
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce((Vector2.up + Vector2.left) * throttle);
        }

        public void Flame()
        {
            throw new System.NotImplementedException();
        }
    }
}
