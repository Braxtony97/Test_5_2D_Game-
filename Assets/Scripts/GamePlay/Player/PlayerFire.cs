using UnityEngine;

namespace Assets.Scripts.GamePlay.Player
{
    public class PlayerFire : MonoBehaviour
    {
        [SerializeField] private BulletPoolPlayer _bulletPoolPlayer;
        public void Fire()
        {
            _bulletPoolPlayer.CreateBullet(this.transform);
        }
    }
}
