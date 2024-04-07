using UnityEngine;
using PlayerConroll;
using UnityEngine.SceneManagement;
using TMPro;

namespace UISetting
{
    public class LoseControl : MonoBehaviour
    {
        private PlayerScore _playerScore;

        public TextMeshProUGUI _finishScore;

        private void Start()
        {
            _playerScore = GetComponent<PlayerScore>();
        }

        void Update()
        {
            _finishScore.text = "You score: " + _playerScore._score.ToString();
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1f;
        }

        public void BackToMenu()
        {
            SceneManager.LoadScene("MainMenu");
            Time.timeScale = 1f;
        }
    }
}

