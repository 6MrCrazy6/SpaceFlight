using UnityEngine;
using PlayerConroll;

namespace EnemyControll
{
    public class EnemyColiderControl : MonoBehaviour
    {
        private PlayerScore _playerScore;
        private PlayerLives _playerLives;

        void Start ()
        {
            _playerScore = FindObjectOfType<PlayerScore>();
            _playerLives = FindObjectOfType<PlayerLives>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _playerLives.DecreaseLife();
                Destroy(gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Finish"))
            {
                _playerScore.AddScore(10);
                Destroy(gameObject);
            }
        }
    }
}


