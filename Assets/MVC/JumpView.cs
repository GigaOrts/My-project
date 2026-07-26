using DG.Tweening;
using UnityEngine;

namespace Assets.MVC
{
    internal class JumpView : MonoBehaviour
    {
        private PlayerControls _controls;
        private JumpController _jumpController;

        void Start()
        {
            var model = new JumpModel();
            _jumpController = new JumpController(model, this);

            if (_controls == null)
            {
                _controls = new PlayerControls();
            }

            _controls.Player.Jump.performed += ctx => _jumpController.HandleJump();
            _controls.Enable();
        }

        void OnDestroy()
        {
            _controls?.Disable();
        }

        public void PlayJumpAnimation(float height, float duration)
        {
            transform.DOJump(
                transform.position,
                height,
                1,
                duration
            ).OnComplete(() => _jumpController.OnJumpComplete());
        }
    }
}