using UnityEngine;

namespace Assets.MVC_Move
{
    internal class KeyboardInput : IPlayerInput
    {
        public float GetHorizontalInput()
        {
            return Input.GetAxisRaw("Horizontal");
        }
    }
}
