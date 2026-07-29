using Assets.Interfaces;
using UnityEngine;

namespace Assets.Bootstraps
{
    internal class PaddleService
    {
        private PaddlePresenter _presenter;
        private IPaddleInput _input;

        public PaddleService(PaddlePresenter presenter, IPaddleInput input)
        {
            _presenter = presenter;
            _input = input;
        }

        public void Tick()
        {
            Vector2 newPosition = _input.GetMousePosition();
            _presenter.Move(newPosition.y);
        }
    }
}
