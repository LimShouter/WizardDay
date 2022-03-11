using UnityEngine;
using UnityTemplateProjects.Utilities;
using UnityTemplateProjects.World.Base.Movement;

namespace World.Base.Movement
{
	public class MovementController : IController
	{
		private readonly MovementModel _model;
		private readonly MovementComponent _component;

		public MovementController(MovementModel model,MovementComponent component)
		{
			_model = model;
			_component = component;
		}
		public void Attach()
		{
			_model.OnUpdate += Update;
		}

		public void Detach()
		{
			_model.OnUpdate -= Update;
		}

		private void Update(float deltaTime)
		{
			_component.transform.rotation = Quaternion.Euler(_component.transform.eulerAngles.x,_model.XRotation,_component.transform.eulerAngles.z);
			_component.transform.Translate(new Vector3(_model.Input.x,0,_model.Input.y) * deltaTime*_model.Description.Speed);
		}
	}
}