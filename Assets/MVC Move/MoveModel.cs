using UnityEngine;

namespace Assets.MVC_Move
{
    internal class MoveModel
    {
        private float _speed;

        public MoveModel(float speed)
        {
            _speed = speed;
        }

        public Vector2 CalculateMove(Vector2 direction, float dt)
        {
            return _speed * dt * direction;
        }
    }
}
