using UnityEngine;

namespace Assets.Scripts.GamePlay.Player
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int _maxHealth = 100;
        [SerializeField] private HealthBar _healthBar;

        private int _currentHealth;

        private void Start()
        {
            _currentHealth = _maxHealth;
        }

        public void ChangeHealth(int damage)
        {
            _currentHealth -= damage;

            if (_currentHealth <= 0)
                Death();
            else
            {
                float currentHealthBarAsPercantage = (float) _currentHealth / _maxHealth;
                _healthBar.OnHealthChanged(currentHealthBarAsPercantage);
            }
        }

        private void Death()
        {
            Destroy(gameObject);
        }
    }
}
