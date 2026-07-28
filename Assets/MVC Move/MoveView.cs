using UnityEngine;

namespace Assets.MVC_Move
{
    internal class MoveView : MonoBehaviour
    {
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        public void UpdateVisualPosition(Vector2 move)
        {
            _transform.Translate(move);
        }
    }
}
