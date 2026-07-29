namespace Assets.MVP
{
    internal class ScoreService
    {
        private ScorePresenter _scorePresenter;
        private float _timer;
        private float _delay;

        public ScoreService(ScorePresenter scorePresenter, float delay)
        {
            _scorePresenter = scorePresenter;
            _delay = delay;
        }

        public void Tick(float dt, int amount)
        {
            _timer += dt;
            if (_timer > _delay)
            {
                _scorePresenter.UpdateScore(amount);
                _timer = 0;
            }
        }

        public void Reset()
        {
            _scorePresenter.ResetScore();
        }
    }
}
