using UnityEngine;
using UnityEngine.SceneManagement;

namespace UISetting
{
    public class PauseControl : MonoBehaviour
    {
        private bool PauseGame;
        public GameObject pauseGameMenu;

        public void Resume()
        {
            pauseGameMenu.SetActive(false);
            Time.timeScale = 1f;
            PauseGame = false;
        }

        public void Pause()
        {
            pauseGameMenu.SetActive(true);
            Time.timeScale = 0f;
            PauseGame = true;
        }

        public void LoadMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
