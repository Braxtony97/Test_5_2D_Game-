using UnityEngine;

namespace Assets.Scripts.GamePlay.Player
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private Joystick _joystick;
        [SerializeField] private Rigidbody2D _rigidbody;
        private float _speedMove = 5f;

        public void JoystickMove()
        {
            Vector2 moveInput = new Vector2(_joystick.Horizontal, _joystick.Vertical);
            _rigidbody.MovePosition(_rigidbody.position + moveInput.normalized * _speedMove * Time.deltaTime);
        }
    }
}
