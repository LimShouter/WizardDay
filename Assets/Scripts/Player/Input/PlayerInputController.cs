using Core;
using Entity.Movement;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player.Input
{
	public class PlayerInputController : IController
	{
		private readonly PlayerInputActionMap _inputActionMap = new PlayerInputActionMap();
		private MovementController playerEntityMovementController;

		public PlayerInputController(MovementController controller)
		{
			playerEntityMovementController = controller;
		}

		public void Attach()
		{
			_inputActionMap.PC.MoveForward.performed += OnMove;
			_inputActionMap.PC.XRotation.performed += OnRotateX;
			_inputActionMap.Enable();
		}

		public void Detach()
		{
			_inputActionMap.Disable();
			_inputActionMap.PC.MoveForward.performed -= OnMove;
			_inputActionMap.PC.XRotation.performed -= OnRotateX;
		}

		private void OnRotateX(InputAction.CallbackContext obj)
		{
			var value = obj.ReadValue<float>();	
			playerEntityMovementController.Rotate(value);
		}

		private void OnMove(InputAction.CallbackContext obj)
		{
			var value = obj.ReadValue<Vector2>();
			Vector3 direction = new Vector3(value.x,0,value.y);
			playerEntityMovementController.Move(direction);
		}
	}
}