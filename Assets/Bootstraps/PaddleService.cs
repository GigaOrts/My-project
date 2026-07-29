namespace Assets.Bootstraps
{
    internal class PaddleService
    {
        private PaddlePresenter _presenter;
        private IInput _input;

        public PaddleService(PaddlePresenter presenter, IInput input)
        {
            _presenter = presenter;
            _input = input;
        }

        public void Tick()
        {
            float positionY = _input.GetMousePositionY();
            _presenter.Move(positionY);
        }
    }
}
