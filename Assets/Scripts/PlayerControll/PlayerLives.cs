using UnityEngine;
using UnityEngine.UI;

namespace PlayerConroll
{
    public class PlayerLives : MonoBehaviour
    {
        public Sprite[] lifeSprites; 
        public int startingLives = 3; 
        private int lives;

        public Image lifeImage;
        public GameObject losePanel;

        void Start()
        {
            lives = startingLives;
            UpdateLifeImage();
        }

        public void DecreaseLife()
        {
            lives--;
            UpdateLifeImage();

            if (lives <= 0)
            {
                Time.timeScale = 0f;
                losePanel.SetActive(true);
            }
        }

        void UpdateLifeImage()
        {
            if (lives >= 0 && lives < lifeSprites.Length)
            {
                lifeImage.sprite = lifeSprites[lives];
            }
        }
    }
}


