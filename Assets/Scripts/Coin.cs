using UnityEngine;

namespace Scripts.Scripts
{
    public class Coin : MonoBehaviour
    {
        protected CoinType Type;

        private void SpawnCoin()
        {
            Instantiate(Resources.Load<GameObject>("Prefab/GoldCoin.prefab"), transform.position, Quaternion.identity);
        }
    }


    public enum CoinType
    {
        Gold = 100,
        Silver = 50
    }
}