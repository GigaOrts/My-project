using UnityEngine;

namespace Assets.MVP
{
    internal class ScoreBootstrap : MonoBehaviour
    {
        [SerializeField] private ScoreView _scoreView;
        [SerializeField] private float _delay;
        [SerializeField] private int _addAmount;

        private ScoreService _scoreService;

        private void Start()
        {
            var scoreModel = new ScoreModel();
            _scoreView.Init(scoreModel);
            var scorePresenter = new ScorePresenter(scoreModel, _scoreView);
            _scoreService = new ScoreService(scorePresenter, _delay);

            _scoreService.Reset();
        }

        private void Update()
        {
            _scoreService.Tick(Time.deltaTime, _addAmount);
        }
    }
}
