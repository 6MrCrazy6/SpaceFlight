using UnityEngine;

namespace EnemyControll
{
    public class EnemySpawner : MonoBehaviour
    {
        public GameObject asteroidPrefab;
        public GameObject spawnParent;

        private float spawnRate = 0.5f;
        private float asteroidSpeed = 2f;
        private float nextSpawnTime;

        private Vector2 spawnRangeX = new Vector2(-1.4f, 1.4f);
        private Vector2 spawnRangeY = new Vector2(5f, 4.5f);

        void Start()
        {
            nextSpawnTime = Time.time + 1f / spawnRate;
        }

        void Update()
        {
            if (Time.time > nextSpawnTime)
            {
                float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
                float randomY = Random.Range(spawnRangeY.x, spawnRangeY.y);

                Vector2 spawnPosition = new Vector2(randomX, randomY);

                GameObject asteroid = Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity, spawnParent.transform);

                Rigidbody2D rb = asteroid.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.velocity = Vector2.down * asteroidSpeed;
                }

                nextSpawnTime = Time.time + 1f / spawnRate;
            }
        }
    }
}

