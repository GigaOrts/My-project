namespace Assets.MVC
{
    internal class JumpModel
    {
        public float JumpHeight { get; set; }
        public float JumpDuration { get; set; }
        public bool IsJumping { get; private set; }

        public JumpModel(float jumpHeight, float jumpDuration)
        {
            JumpHeight = jumpHeight;
            JumpDuration = jumpDuration;
        }

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