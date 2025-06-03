using UnityEngine;

namespace RollingBall
{
    public class Coin : MonoBehaviour
    {
        protected CoinType Type;
        
        private void SpawnCoin(){}
    }



    public enum CoinType
    {
        Gold=100
        ,Silver=50
    }
}