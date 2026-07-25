namespace Assets.NoMono
{
    internal class GameItem
    {
        private string _name;
        private string _rarity;

        public GameItem(string name, string rarity)
        {
            _name = name;
            _rarity = rarity;
        }

        internal string GetInfo()
        {
            return $"ITEM Name: {_name} | Rarity: {_rarity}";
        }
    }
}