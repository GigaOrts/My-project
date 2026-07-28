using UnityEngine;

namespace Assets.MVC_Move
{
    internal class MoveController
    {
        private IPlayerInput _playerInput;
        private MoveView _moveView;
        private MoveModel _moveModel;

        public MoveController(IPlayerInput playerInput, 
            MoveView moveView, MoveModel moveModel)
        {
            _playerInput = playerInput;
            _moveView = moveView;
            _moveModel = moveModel;
        }

        public void Tick(float dt)
        {
            float hor = _playerInput.GetHorizontalInput();
            Vector2 direction = new Vector2(hor, 0);
            Vector2 move = _moveModel.CalculateMove(direction, dt);
            _moveView.UpdateVisualPosition(move);
        }
    }
}
