using Assets.Features.Ball;
using Assets.Interfaces;
using Assets.Features.InputPaddle;
using UnityEngine;

namespace Assets.Bootstraps
{
    internal class Bootstrap : MonoBehaviour
    {
        [SerializeField] private PaddleCongif _paddleConfigPlayer;
        [SerializeField] private PaddleCongif _paddleConfigAI;
        [SerializeField] private PaddleView _paddleViewPlayer;
        [SerializeField] private PaddleView _paddleViewAI;
        [SerializeField] private BallConfig _ballConfig;
        [SerializeField] private BallView _ballView;
        [SerializeField] private float _ballPushForce;

        private PaddleModel _paddleModelPlayer;
        private PaddleModel _paddleModelAI;
        private PaddleService _paddleServicePlayer;
        private PaddleService _paddleServiceAI;

        private BallModel _ballModel;
        private BallPresenter _ballPresenter;

        private void Awake()
        {
            _ballModel = new BallModel();
            _ballPresenter = new BallPresenter(_ballModel, _ballView);

            InitPlayer();
            InitAI();
        }

        private void Start()
        {
            _ballPresenter.Push(_ballPushForce);
        }

        private void Update()
        {
            _paddleServicePlayer.Tick();
            _paddleServiceAI.Tick();

            _ballPresenter.Tick();
        }

        private void LateUpdate()
        {
            //_paddleServiceAI.Tick();

        }
        
        private void InitAI()
        {
            _paddleModelAI = new PaddleModel(
                            _paddleConfigAI.Position,
                            _paddleConfigAI.Bounds);
            IPaddleInput inputAI = new InputAI(_ballModel);
            PaddlePresenter presenterAI = new PaddlePresenter(
                _paddleModelAI,
                _paddleViewAI);
            _paddleServiceAI = new PaddleService(presenterAI, inputAI);
        }

        private void InitPlayer()
        {
            _paddleModelPlayer = new PaddleModel(
                            _paddleConfigPlayer.Position,
                            _paddleConfigPlayer.Bounds);
            IPaddleInput inputPlayer = new InputPlayer();
            PaddlePresenter presenterPlayer = new PaddlePresenter(
                _paddleModelPlayer,
                _paddleViewPlayer);
            _paddleServicePlayer = new PaddleService(presenterPlayer, inputPlayer);
        }

    }
}
