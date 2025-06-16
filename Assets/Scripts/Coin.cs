using System;
using UnityEngine;

namespace Scripts.Scripts
{
    public unsafe class Coin : MonoBehaviour
    {
        protected CoinType Type;
        public Vector3 Cointransform;
     

        private void SpawnCoin()
        {
            Instantiate(Resources.Load<GameObject>("Prefab/GoldCoin.prefab"), transform.position, Quaternion.identity);
        }

        private void FixedUpdate()
        {
            this.transform.Rotate(Cointransform*1*Time.deltaTime);
        }
     
    }


    public enum CoinType
    {
        Gold = 100,
        Silver = 50
    }
    
   
}