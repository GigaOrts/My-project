using UnityEngine;

namespace Assets.NoMono
{
    internal class Hero
    {
        private string _name;
        private int _level;
        private int _coinsAmount;

        public Hero(string name, int level, int coinsAmount)
        {
            _name = name;
            _level = level;
            _coinsAmount = coinsAmount;
        }

        internal string GetInfo()
        {
            return $"HERO Name: {_name} | Level: {_level} | Coins: {_coinsAmount}";
        }

        public void FindItem(GameItem gameItem)
        {
            Debug.LogWarning($"{_name} found {gameItem.GetInfo()}");
        }
    }
}