using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GamePlay.Player
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Image _healthBarFilling;

        public void OnHealthChanged(float valueAsPercentage)
        {
            _healthBarFilling.fillAmount = valueAsPercentage;
        }
    }
}
