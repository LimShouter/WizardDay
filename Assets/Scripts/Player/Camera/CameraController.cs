using UnityEngine;
using UnityTemplateProjects.Utilities;

namespace Player.Camera
{
	public class CameraController : IController
	{
		private readonly CameraModel _model;
		private readonly CameraComponent _component;

		public CameraController(CameraModel model, CameraComponent component)
		{
			_model = model;
			_component = component;
		}

		public void Attach()
		{
			_model.OnMove += Move;
		}

		public void Detach()
		{
			_model.OnMove -= Move;
		}

		private void Move(float obj)
		{
			_model.CurrentAngle =
				Mathf.Clamp(_model.CurrentAngle - obj * Time.deltaTime * _model.Description.Sensitivity,
					_model.Description.MinY, _model.Description.MaxY);
			_component.transform.rotation = Quaternion.Euler(_model.CurrentAngle,_component.transform.eulerAngles.y,_component.transform.eulerAngles.z);
		}
	}
}