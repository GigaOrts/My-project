using Assets.Interfaces;
using UnityEngine;

namespace Assets.Features.InputPaddle
{
    internal class InputPlayer : IPaddleInput
    {
        public Vector2 GetMousePosition()
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
