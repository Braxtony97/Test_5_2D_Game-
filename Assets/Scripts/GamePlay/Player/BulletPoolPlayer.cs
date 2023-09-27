using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.GamePlay.Player
{
    internal class BulletPoolPlayer : MonoBehaviour
    {
        [SerializeField] private int _bulletsCount;
        [SerializeField] private GameObject _bulletPlayerPrefab;
        [SerializeField] private Transform _targetEnemy;

        private float _lifeTimeBullet = 3f;
        private List<GameObject> _bulletsPlayerPool;

        private void Start()
        {
            InstantiateBulletPool();
        }

        private void InstantiateBulletPool()
        {
            _bulletsPlayerPool = new List<GameObject>();

            for (int i = 0; i < _bulletsCount; i++)
            {
                GameObject bullet = Instantiate(_bulletPlayerPrefab, this.transform);
                bullet.SetActive(false);
                _bulletsPlayerPool.Add(bullet);
            }
        }

        public GameObject CreateBullet(Transform Position)
        {
            foreach (GameObject bullet in _bulletsPlayerPool)
            {
                if (!bullet.activeInHierarchy)
                {
                    bullet.transform.position = Position.transform.position;
                    bullet.GetComponent<PlayerBulletBehaviour>().SetTareget(_targetEnemy);
                    bullet.SetActive(true);
                    StartCoroutine(DeactivateBullet(bullet));
                    return bullet;
                }
            }
            return null;
        }

        IEnumerator DeactivateBullet (GameObject Bullet)
        {
            yield return new WaitForSeconds(_lifeTimeBullet);
            Bullet.SetActive(false);   
        }

        /*private void OnTriggerEnter2D(Collider2D EnemyCollider)
        {
            if (EnemyCollider.CompareTag("Enemy"))
            {
                _targetEnemy = EnemyCollider.transform;
            }
        }*/

        private void OnTriggerStay2D(Collider2D EnemyCollider)
        {
            if (EnemyCollider.CompareTag("Enemy"))
            {
                _targetEnemy = EnemyCollider.transform;
            }
        }

        private void OnTriggerExit2D(Collider2D EnemyCollider)
        {
            _targetEnemy = null;
        }
    }
}
