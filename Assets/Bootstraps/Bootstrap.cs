using UnityEngine;

namespace Assets.Bootstraps
{
    internal class Bootstrap : MonoBehaviour
    {
        [SerializeField] private PaddleCongif _paddlePlayerConfig;
        [SerializeField] private PaddleView _paddlePlayerView;
        private PaddleModel _paddlePlayerModel;
        private PaddleModel _paddleAIModel;
        private PaddleService _paddleService;

        private BallModel _ball;

        private void Awake()
        {
            _paddlePlayerModel = new PaddleModel(_paddlePlayerConfig.Position, _paddlePlayerConfig.Bounds);
            InputPlayer inputPlayer = new InputPlayer();
            PaddlePresenter presenterPlayer = new PaddlePresenter(_paddlePlayerModel, _paddlePlayerView);
            _paddleService = new PaddleService(presenterPlayer, inputPlayer);
        }

        private void Update()
        {
            _paddleService.Tick();
        }
    }
}
