using UnityEngine;
using UnityEngine.UI;


namespace Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        private GameController _gameController;

        public delegate void GameOver(AudioSource gamesound);

        public event GameOver over;
        [SerializeField] private Button pause;
        [Space][SerializeField] private Button leftArrow;
        [Space][SerializeField] private Button rightArrow;
        [Space][SerializeField] private AudioSource coinUpSound;
        [Space][SerializeField] private AudioSource coinDownSound;
        [Space][SerializeField] private Button jumpButton;
        [SerializeField][Range(0, 200)] private float jumHeight;
        private Rigidbody _rb;
        [Range(0, 300)] public float forwardSpeed;
        [Range(0, 100)] public float verticalSpeed;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            if (over != null)
            {
                over += _gameController.OnGameOver;
            }
        }

        private void Update()
        {
            leftArrow.onClick.AddListener(() => { _rb.AddForce(Vector3.left * verticalSpeed); }
            );
            rightArrow.onClick.AddListener(() => { _rb.AddForce(Vector3.right * verticalSpeed); }
            );
            jumpButton.onClick.AddListener(() => { _rb.AddForce(Vector3.up * jumHeight); });
            _rb.AddForce(Vector3.forward * forwardSpeed, ForceMode.Impulse);
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Coin"))
            {
                coinUpSound.Play();
                Destroy(collision.gameObject);
            }
        }
    }


}