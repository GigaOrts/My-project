namespace Assets.MVC
{
    internal class JumpModel
    {
        public float JumpHeight { get; set; } = 3f;
        public float JumpDuration { get; set; } = 0.5f;
        public bool IsJumping { get; private set; }

        public void StartJump()
        {
            IsJumping = true;
        }

        public void EndJump()
        {
            IsJumping = false;
        }
    }
}