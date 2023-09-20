using UnityEngine;

namespace Assets.Scripts.GamePlay.Player
{
    public class PlayerBulletBehaviour : MonoBehaviour
    {
        private float _bulletSpeed = 5f;

        private void Update()
        {
            transform.Translate(Vector2.right * _bulletSpeed * Time.deltaTime);
        }
    }
}
