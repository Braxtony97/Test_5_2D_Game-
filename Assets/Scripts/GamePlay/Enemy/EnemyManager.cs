
using UnityEngine;

namespace Assets.Scripts.GamePlay.Enemy
{
    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyPrefab;
        private int _numberOfEnemys = 3;

        private int _minX = -5;
        private int _maxX = 5;
        private int _minY = -4;
        private int _maxY = 4;

        public void Awake()
        {
            for (int i = 0; i < _numberOfEnemys; i++)
            {
                float randomX = Random.Range(_minX, _maxX);
                float randomY = Random.Range(_minY, _maxY);

                Instantiate(_enemyPrefab, new Vector2(randomX, randomY), Quaternion.identity);
            }
        }
    }
}
