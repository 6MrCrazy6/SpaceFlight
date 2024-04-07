using UnityEngine;
using UnityEngine.SceneManagement;

namespace UISetting
{
    public class MainMenuControl : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene("Game");
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

