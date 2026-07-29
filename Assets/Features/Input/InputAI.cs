using Assets.Features.Ball;
using Assets.Interfaces;
using UnityEngine;

namespace Assets.Features.InputPaddle
{
    internal class InputAI : IPaddleInput
    {
        private BallModel _ballModel;

        public InputAI(BallModel ballModel)
        {
            _ballModel = ballModel;
        }

        public Vector2 GetMousePosition()
        {
            return _ballModel.Position;
        }
    }
}
