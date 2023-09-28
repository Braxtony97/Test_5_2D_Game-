using UnityEngine;

namespace Assets.Scripts.GamePlay.Player
{
    [RequireComponent(typeof(Collider2D))]

    public class PlayerBulletBehaviour : MonoBehaviour
    { 
        private float _bulletSpeed = 5f;
        private Transform _targetEnemy;

        public void SetTareget(Transform TargetEnemy)
        {
            _targetEnemy = TargetEnemy;
        }

        private void Update()
        {
            if (_targetEnemy != null)
            {
                Vector2 direction = (_targetEnemy.position - transform.position).normalized;
                transform.Translate(direction * _bulletSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.right * _bulletSpeed * Time.deltaTime);
            }
        }

        private void OnTriggerEnter2D(Collider2D EnemyCollider)
        {
            if (EnemyCollider.CompareTag("Enemy"))
            {
                EnemyCollider.GetComponent<Health>().ChangeHealth(10);
            }
        }
    }
}
