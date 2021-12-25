using UnityEngine;

namespace Liskov_Substitution
{
    public class Instantiater : MonoBehaviour
    {
        public GameObject prefab;
        [SerializeField] private float initTime;
        private float _timer;

        private void Awake()
        {
            _timer = initTime;
        }

        private void FixedUpdate()
        {
            _timer -= Time.deltaTime;
            if (!(_timer <= 0)) return;
            Instantiate(prefab, gameObject.transform.localPosition, Quaternion.identity); 
            _timer = initTime;
        }
    }
}
