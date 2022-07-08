using Cinemachine;
using Descriptions;
using Entity;
using Entity.Movement;
using Player.Input;
using UnityEngine;

namespace Player
{
	public class PlayerManager
	{
		private IPlayerDescription _description;
		private EntityFacade _entity;
		private PlayerInputController _controller;
		private CinemachineStateDrivenCamera _cameraMachine;

		public void InitializePlayer(IPlayerDescription description)
		{
			_description = description;
			_entity = EntityManager.Instance.Create(description.EntityDescription);
			AttachPlayerToEntity(_entity);
			InitializePlayerCameraMachine();
		}

		private void AttachPlayerToEntity(EntityFacade entity)
		{
			_controller = new PlayerInputController(entity.GetController<MovementController>());
			_controller.Attach();
		}

		private void DetachPlayerFromEntity()
		{
			_controller.Detach();
			_controller = null;
		}


		public void DestroyPlayer()
		{
			DetachPlayerFromEntity();
			_description = null;
			Object.Destroy(_entity);
			DestroyPlayerCameraMachine();
		}

		private void InitializePlayerCameraMachine()
		{
			_cameraMachine = Object.Instantiate(_description.CameraPrefab);
			var transform = _entity.transform;
			for (int i = 0; i < _cameraMachine.ChildCameras.Length; i++)
			{
				_cameraMachine.ChildCameras[i].Follow = transform;
				_cameraMachine.ChildCameras[i].LookAt = transform;
			}
		}


		private void DestroyPlayerCameraMachine()
		{
			Object.Destroy(_cameraMachine);
			_cameraMachine = null;
		}
	}
}