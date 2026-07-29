using UnityEngine;

namespace Assets.Bootstraps
{
    internal class PaddleModel
    {
        public Vector2 Position;
        public PaddleBounds Bounds;

        public PaddleModel(Vector2 position, PaddleBounds bounds)
        {
            Position = position;
            Bounds = bounds;
        }

        public bool CheckBounds(Vector2 position)
        {
            return position.y > Bounds.Bottom &&
                   position.y < Bounds.Top;
        }
    }
}