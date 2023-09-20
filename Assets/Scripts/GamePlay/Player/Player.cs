using Assets.Scripts.GamePlay.Interface;
using Assets.Scripts.GamePlay.Player;
using UnityEngine;

public class Player : MonoBehaviour, IMoveable
{
    [SerializeField] private PlayerMove _playerMove;

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        _playerMove.JoystickMove();
    }
}
