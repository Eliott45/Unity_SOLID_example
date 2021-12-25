using UnityEngine;

namespace Open_closed
{
    public class Coin : MonoBehaviour
    {
        public CoinType Type;
        public DestroyType DType;
    
        public class CoinTypeSpecification : ISpecification<Coin>
        {
            private readonly CoinType _type;

            public CoinTypeSpecification(CoinType type)
            {
                _type = type;
            }

            public bool IsClassified(Coin item) => item.Type == _type;
        }

        public class DestroyableSpecification : ISpecification<Coin>
        {
            private readonly DestroyType _type;

            public DestroyableSpecification(DestroyType type)
            {
                _type = type;
            }

            public bool IsClassified(Coin item) => item.DType == _type;
        }

        public enum CoinType
        {
            Good,
            Bad,
        }

        public enum DestroyType
        {
            Fast,
            Slow,
            None,
        }
    }
}
