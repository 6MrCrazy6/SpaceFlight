using TMPro;
using UnityEngine;

namespace PlayerConroll
{
    public class PlayerScore : MonoBehaviour
    {
        public TextMeshProUGUI _scoreText;
        public int _score = 0;

        public void AddScore(int score)
        {
            _score += score;
            UpdateScoreText();
        }

        private void UpdateScoreText()
        {
            _scoreText.text = "Score: " + _score.ToString();
        }
    }
}
