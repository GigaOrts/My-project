using UnityEngine;

namespace Assets.NoMono
{
    internal class GameBootstrap : MonoBehaviour
    {
        private void Start()
        {
            Hero hero = new Hero("Dima", 1, 100);

            GameItem[] gameItems =
            {
                new GameItem(GameItemNames.Sword, GameItemRarities.Common),
                new GameItem(GameItemNames.Shield, GameItemRarities.Rare),
                new GameItem(GameItemNames.Potion, GameItemRarities.Common)
            };

            Debug.Log("=== Hero preparation ===");
            Debug.Log(hero.GetInfo());
            foreach (GameItem item in gameItems)
            {
                Debug.Log(item.GetInfo());
            }
            Debug.Log("=== Preparation done ===");

            hero.FindItem(gameItems[Random.Range(0, gameItems.Length)]);
        }
    }
}
