using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts
{
    public class GameController : MonoBehaviour
    {
        public AudioSource soundobject;
        [SerializeField] private Button pause;
        [SerializeField] private GameObject pauseMenu;
         private readonly GameObject roadPiece;
        [SerializeField] private Button resume;
        [SerializeField] private Button quit;
        [SerializeField] private Button restart;
        private AudioSource _gameSound;

        private void Awake()
        {
            _gameSound = GetComponent<AudioSource>();
        }

        private void Start()
        {
            pause.onClick.AddListener(() => { PauseGame(pauseMenu, _gameSound); });
            resume.onClick.AddListener(() => { ResumeGame(pauseMenu, _gameSound); });
            restart.onClick.AddListener(() => { Restart(); });
            Instantiation.InstantiateRoadPieces(roadPiece, 20);
        }

        private void PauseGame(GameObject menu, AudioSource gamesound)
        {
            menu.SetActive(true);
            Time.timeScale = 0;
            gamesound.Pause();
        }

        private void ResumeGame(GameObject menupanel, AudioSource gamesound)
        {
            menupanel.SetActive(false);
            Time.timeScale = 1;
            gamesound.UnPause();
        }

        private void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }

        public void OnGameOver(AudioSource gamesound)
        {
            Time.timeScale = 0;
            gamesound.Stop();
        }
    }
}