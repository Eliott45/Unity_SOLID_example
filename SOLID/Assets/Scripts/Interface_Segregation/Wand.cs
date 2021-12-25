using UnityEngine;

namespace Interface_Segregation
{
    public class Wand : MonoBehaviour, IFlame
    {
        private float _timer = 1f;
        private int _redShades = 4;

        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0 && _redShades >= 0)
            {
                Flame();
                _redShades--;
                _timer = 1f;
                if(_redShades == 0)
                    Destroy(gameObject);
            }

        }
        public void Flame()
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, ((float)_redShades/4));
        }
    }
}