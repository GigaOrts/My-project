using DG.Tweening;
using UnityEngine;

namespace Assets.MVC
{
    internal class JumpView : MonoBehaviour
    {
        private PlayerControls _playerControls;
        private JumpController _jumpController;

        public void Init(
            PlayerControls playerControls, 
            JumpController jumpController, 
            JumpModel jumpModel)
        {
            _playerControls = playerControls;
            _jumpController = jumpController;

            _playerControls.Player.Jump.performed += ctx => _jumpController.HandleJump();
            _playerControls.Enable();
        }

        void OnDestroy()
        {
            _playerControls?.Disable();
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