using UnityEngine;

namespace Assets.Bootstraps
{
    internal class InputPlayer : IInput
    {
        public float GetMousePositionY()
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        }
    }
}
