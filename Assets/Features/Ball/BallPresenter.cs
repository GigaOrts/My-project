using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assets.Features.Ball
{
    internal class BallPresenter
    {
        private BallModel _model;
        private BallView _view;

        public BallPresenter(BallModel model, BallView view)
        {
            _model = model;
            _view = view;
        }

        public void Push(float force)
        {
            _view.Push(force);
        }

        public void Tick()
        {
            _model.Position = _view.Position;
        }
    }
}
