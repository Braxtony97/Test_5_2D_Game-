using Assets.Scripts.GamePlay.Interface;
using Assets.Scripts.GamePlay.Player;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour, IMoveable, IFireable
{
    [SerializeField] private PlayerMove _playerMove;
    [SerializeField] private PlayerFire _playerFire;
    [SerializeField] private Button _buttonFire;
    [SerializeField] private PlayerBulletBehaviour _playerBulletBehaviour;
    [SerializeField] private BulletPoolPlayer _bulletPoolPlayer;
    [SerializeField] private Health _health;

    private void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _health.ChangeHealth(10);
        }
    }

    public void Move()
    {
        _playerMove.JoystickMove();
    }

    private void OnEnable()
    {
        _buttonFire.onClick.AddListener(Fire);
    }

    public void Fire()
    {
        _playerFire.Fire();
    }
}
