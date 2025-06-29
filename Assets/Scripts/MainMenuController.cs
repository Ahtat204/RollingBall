using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] public Animator transition;
        public float duration = 1f;
        [SerializeField] private Button playbutton;

        private void Start()
        {
            playbutton.onClick.AddListener(StartAnimation);
        }


        private void StartAnimation()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}