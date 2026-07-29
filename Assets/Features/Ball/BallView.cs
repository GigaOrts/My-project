using UnityEngine;

namespace Assets.Features.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    internal class BallView : MonoBehaviour
    {
        private Rigidbody2D _rb;
        private Transform _transform;

        public Vector2 Position => _transform.position;

        private void Awake()
        {
            _transform = transform;
            _rb = GetComponent<Rigidbody2D>();
        }

        public void Push(float force)
        {
            _transform.rotation = Quaternion.Euler(0, 0, -60);
            _rb.AddForce(transform.up * force, ForceMode2D.Impulse);
        }
    }
}