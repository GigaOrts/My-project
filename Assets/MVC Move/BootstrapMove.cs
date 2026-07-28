using UnityEngine;

namespace Assets.MVC_Move
{
    internal class BootstrapMove : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private MoveView _moveView;

        private IPlayerInput _playerInput;
        private MoveModel _moveModel;
        private MoveController _controller;

        private void Awake()
        {
            _playerInput = new KeyboardInput();
            _moveModel = new MoveModel(_speed);

            _controller = new MoveController(_playerInput, _moveView, _moveModel);
        }

        private void Update()
        {
            _controller.Tick(Time.deltaTime);
        }
    }
}
