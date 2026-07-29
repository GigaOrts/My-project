namespace Assets.MVP
{
    internal class ScorePresenter
    {
        private ScoreModel _scoreModel;
        private ScoreView _scoreView;

        public ScorePresenter(ScoreModel scoreModel, ScoreView scoreView)
        {
            _scoreModel = scoreModel;
            _scoreView = scoreView;
        }

        public void UpdateScore(int amount)
        {
            _scoreModel.Add(amount);
            _scoreView.Render();
        }

        public void ResetScore()
        {
            _scoreModel.Reset();
            _scoreView.Render();
        }
    }
}
