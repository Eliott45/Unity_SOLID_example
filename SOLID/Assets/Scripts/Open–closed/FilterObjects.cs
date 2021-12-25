using System.Collections.Generic;
using System.Linq;
using Open_closed;
using UnityEngine;

namespace Open_closed
{
    public class FilterObjects : MonoBehaviour
    {
        private readonly List<Coin> _allCoins = new List<Coin>();
        private List<Coin> _reColorCoins = new List<Coin>();
        private List<Coin> _destroyCoins = new List<Coin>();

        private readonly CoinFilter _cf = new CoinFilter();

        private void OnTriggerEnter2D(Collider2D col)
        {
            _allCoins.Add(col.GetComponent<Coin>());
            _reColorCoins = _cf.Filter(_allCoins, new Coin.CoinTypeSpecification(Coin.CoinType.Good));
            RecolorObjects(_reColorCoins);
            _destroyCoins = _cf.Filter(_allCoins, new Coin.DestroyableSpecification(Coin.DestroyType.Fast));
            DestroyObjects(_destroyCoins);
        }

        private static void RecolorObjects(List<Coin> inputList)
        {
            foreach (var coin in inputList)
            {
                coin.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0, 1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f), 1);
            }
        }

        private static void DestroyObjects(List<Coin> inputList)
        {
            foreach (var coin in inputList)
            {
                coin.gameObject.SetActive(false);
            }
        }
    }
}

public class CoinFilter : IFilter<Coin>
{
    public List<Coin> Filter(IEnumerable<Coin> objects, ISpecification<Coin> specification) =>
        objects.Where(specification.IsClassified).ToList();
}
