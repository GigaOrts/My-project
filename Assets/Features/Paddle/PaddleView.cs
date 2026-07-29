using UnityEngine;

namespace Assets.Bootstraps
{
    internal class PaddleView : MonoBehaviour
    {
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        internal void UpdatePosition(Vector2 position)
        {
            _transform.position = position;
        }
    }
}