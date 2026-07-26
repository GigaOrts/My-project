using UnityEngine;

namespace Assets.MVC
{
    internal class Bootstrap : MonoBehaviour
    {
        [SerializeField] private float jumpHeight;
        private JumpController _jumpController;

        //private void Start()
        //{
        //    _jumpController = new JumpController();
        //}

        //private void Update()
        //{
        //    _jumpController.Jump();
        //}
    }
}
