using UnityEngine;
using UnityEngine.Events;

namespace Single_Responsibility
{
    public class CheckInput : MonoBehaviour
    {
        public KeyCode InvokingKey;
        public UnityEvent keyPressed;

        private void Update()
        {
            if (Input.GetKeyDown(InvokingKey))
            {
                keyPressed.Invoke();
            }
        }
    }
}
