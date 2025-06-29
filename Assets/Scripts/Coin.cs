using UnityEngine;


namespace Scripts
{
    public unsafe class Coin : MonoBehaviour
    {
        [SerializeField] private CoinType type;
        private Vector3 rotationRate;
        private Vector3 _position;

        private void FixedUpdate()
        {
            this.transform.Rotate(rotationRate * Time.deltaTime);
        }

        private void Awake()
        {
            rotationRate = Vector3.one;
            _position = transform.position;
        }

        /*void Start()
        {

            var inc = 0;
            while (inc < 5)
            {
                var clamped = _position.Random(Vector3.zero, Vector3.one);
                Instantiate(gameObject, clamped, Quaternion.identity);
                inc++;
            }
        }*/
    }


    public enum CoinType
    {
        Gold = 100,
        Silver = 50
    }
}

namespace utils
{
    public static class RandomVector3
    {
        public static Vector3 Clamp(this Vector3 value, Vector3 min, Vector3 max) => new(
            Mathf.Clamp(value.x, min.x, max.x), Mathf.Clamp(value.y, min.y, max.y), Mathf.Clamp(value.z, min.z, max.z));

        public static Vector3 Random(this Vector3 value, Vector3 max, Vector3 min) => new(
            UnityEngine.Random.Range(min.x, max.x), UnityEngine.Random.Range(min.y, max.y),
            UnityEngine.Random.Range(min.z, max.z)
        );
    }
}