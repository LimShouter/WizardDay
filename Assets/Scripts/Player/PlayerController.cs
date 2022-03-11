using Main;
using Player.Camera;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityTemplateProjects.Utilities;
using UnityTemplateProjects.World.Base.Movement;
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
		private readonly DefaultInputActionMap _defaultInputActionMap;
		public PlayerController(GlobalContext context,PlayerModel model,PlayerComponent component)
		{
			_context = context;
			_model = model;
			_component = component;
			_component.Initialize();
			_movementController = new MovementController(_model.MovementModel, _component.MovementComponent);
			_cameraController = new CameraController(_model.CameraModel, _component.CameraComponent);
			_defaultInputActionMap = new DefaultInputActionMap();
			// var interactionController = new InteractionController(_model.InteractionModel, _component.InteractionComponent);
		}
		public void Attach()
		{
			_movementController.Attach();
			_cameraController.Attach();
			
			_context.Engine.Add(_model.MovementModel);
			AttachInput();
			UnityEngine.Camera.SetupCurrent(_component.CameraComponent.GetComponent<UnityEngine.Camera>());
		}

		public void Detach()
		{
			DetachInput();
			_context.Engine.Remove(_model.MovementModel);
			
			_movementController.Detach(); 
			_cameraController.Detach();
		}

		private void AttachInput()
		{
			_defaultInputActionMap.PC.Enable();
			_defaultInputActionMap.PC.MoveForward.performed += MovingProccess;
			_defaultInputActionMap.PC.MoveForward.canceled += MovingProccess;
			
			_defaultInputActionMap.PC.XRotation.performed += XRotate;
			_defaultInputActionMap.PC.YRotation.performed += YRotate;
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

		private void YRotate(InputAction.CallbackContext obj)
		{
			_model.CameraModel.Move(obj.ReadValue<float>());
		}

		private void XRotate(InputAction.CallbackContext obj)
		{ 
			_model.MovementModel.AddXRotation(obj.ReadValue<float>() * Time.deltaTime * _model.CameraModel.Description.Sensitivity);
		}

		private void MovingProccess(InputAction.CallbackContext obj)
		{
			var value = obj.ReadValue<Vector2>();
			_model.MovementModel.SetInput(value);
		}

		private void DetachInput()
		{
			_defaultInputActionMap.PC.Disable();
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}