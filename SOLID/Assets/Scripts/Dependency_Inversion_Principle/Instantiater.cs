using UnityEngine;

namespace Dependency_Inversion_Principle
{
    class Instantiater : MonoBehaviour
    {
        public GameObject prefab;
        public float initTime;
        private float _timer;

        private void Awake()
        {
            _timer = initTime;
        }

        private void FixedUpdate()
        {
            if (initTime > 0)
                _timer -= Time.deltaTime;

            if (_timer <= 0)
            {
                _timer -= Time.deltaTime;
                if (_timer <= 0)
                {
                    Instantiate(prefab, gameObject.transform.localPosition, Quaternion.identity);
                    _timer = initTime;
                }
            }
      
        }
    }
}