using Main;
using Player.Camera;
using UnityTemplateProjects.Utilities;
using World.Base.Movement;

namespace Player
{
	public class PlayerController : IController
	{
		private readonly GlobalContext _context;
		private readonly PlayerModel _model;
		private readonly PlayerComponent _component;
		private readonly MovementController _movementController;
		private readonly CameraController _cameraController;
		public PlayerController(GlobalContext context,PlayerModel model,PlayerComponent component)
		{
			_context = context;
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
			
			_context.Engine.Add(_model.MovementModel);
		}

		public void Detach()
		{
			
			_context.Engine.Remove(_model.MovementModel);
			
			_movementController.Detach(); 
			_cameraController.Detach();
		}
	}
}