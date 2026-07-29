using UnityEngine;

namespace Assets.Bootstraps
{
    [CreateAssetMenu(fileName = "Paddle", menuName = "SO/Paddle")]
    internal class PaddleCongif : ScriptableObject
    {
        public Vector2 Position;
        public PaddleBounds Bounds;
    }
}
