using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.MVP
{
    internal class ScoreView : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private ScoreModel _scoreModel;

        public void Init(ScoreModel scoreModel)
        {
            _scoreModel = scoreModel;
        }

        public void Render()
        {
            _text.text = _scoreModel.Score.ToString();
        }
    }
}
