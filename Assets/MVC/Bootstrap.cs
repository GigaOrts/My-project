using UnityEngine;

namespace Assets.MVC
{
    internal class Bootstrap : MonoBehaviour
    {
        [SerializeField] private float _jumpHeight = 3;
        [SerializeField] private float _jumpDuration = 0.5f;
        [SerializeField] private JumpView _jumpView;

        private JumpController _jumpController;

        private void Start()
        {
            PlayerControls playerControls = new PlayerControls();

            var jumpModel = new JumpModel(_jumpHeight, _jumpDuration);
            _jumpController = new JumpController(jumpModel, _jumpView);
            _jumpView.Init(playerControls, _jumpController, jumpModel);
        }
    }
}
