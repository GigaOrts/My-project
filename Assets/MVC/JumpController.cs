namespace Assets.MVC
{
    internal class JumpController
    {
        private JumpModel _model;
        private JumpView _view;

        public JumpController(JumpModel model, JumpView view)
        {
            _model = model;
            _view = view;
        }

        public void HandleJump()
        {
            if (_model.IsJumping) 
                return;

            _model.StartJump();
            _view.PlayJumpAnimation(_model.JumpHeight, _model.JumpDuration);
        }

        public void OnJumpComplete()
        {
            _model.EndJump();
        }
    }
}