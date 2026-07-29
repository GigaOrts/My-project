using UnityEngine;

namespace Assets.Bootstraps
{
    internal class PaddlePresenter
    {
        private PaddleModel _model;
        private PaddleView _view;

        public PaddlePresenter(PaddleModel model, PaddleView view)
        {
            _model = model;
            _view = view;
        }

        public void Move(float posY)
        {
            Vector2 newPos = new Vector2(_model.Position.x, posY);
            
            if (_model.CheckBounds(newPos) == false)
                return;

            _model.Position = newPos;
            _view.UpdatePosition(_model.Position);
        }
    }
}