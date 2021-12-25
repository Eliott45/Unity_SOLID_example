using UnityEngine;
using UnityEngine.Events;

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
