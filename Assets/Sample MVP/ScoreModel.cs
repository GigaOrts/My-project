using System;

namespace Assets.MVP
{
    internal class ScoreModel
    {
        private int _score;
        public int Score => _score;

        public void Reset()
        {
            _score = 0;
        }

        public void Add(int amount)
        {
            if(amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            _score += amount;
        }
    }
}
