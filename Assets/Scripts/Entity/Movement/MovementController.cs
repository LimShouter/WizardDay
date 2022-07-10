using Core;
using Core.Systems;
using UnityEngine;

namespace Entity.Movement
{
	public class MovementController : IEntityController, IUpdatable
	{
		private readonly EntityFacade _entity;
		private readonly MovementModel _model;
		private readonly MovementView _view;

		public MovementController(EntityFacade entity,MovementModel model,MovementView view)
		{
			_entity = entity;
			_model = model;
			_view = view;
		}
		public void Attach()
		{
			UpdateSystem.Instance.Add(this);
		}

		public void Detach()
		{
			UpdateSystem.Instance.Remove(this);
		}

		public void Rotate(float delta)
		{
			_view.transform.Rotate(Vector3.up,delta * Time.deltaTime);
		}

		public void Move(Vector3 direction)
		{
			_model.Direction = direction;
		}

		public void Jump()
		{
			// _view.rigidbody.AddForce(Vector3.up*_model.description.JumpForce,ForceMode.Impulse);
		}

		public void ManualUpdate(float deltaTime)
		{
			_view.transform.Translate(_model.Direction * (_model.Description.Speed * Time.deltaTime));
		}
	}
}