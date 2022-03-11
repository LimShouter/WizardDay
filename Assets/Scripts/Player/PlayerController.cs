using Player.Camera;
using UnityTemplateProjects.Utilities;
using UnityTemplateProjects.World.Base.Interaction;
using World.Base.Movement;

namespace Player
{
	public class PlayerController : IController
	{
		private readonly PlayerModel _model;
		private readonly PlayerComponent _component;
		private readonly MovementController _movementController;
		private readonly CameraController _cameraController;
		public PlayerController(PlayerModel model,PlayerComponent component)
		{
			_model = model;
			_component = component;
			_movementController = new MovementController(_model.MovementModel, _component.MovementComponent);
			_cameraController = new CameraController(_model.CameraModel, _component.CameraComponent);
			// var interactionController = new InteractionController(_model.InteractionModel, _component.InteractionComponent);
		}
		public void Attach()
		{
			_movementController.Attach();
			_cameraController.Attach();
		}

		public void Detach()
		{
			_movementController.Detach(); 
			_cameraController.Detach();
		}
	}
}