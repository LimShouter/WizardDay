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
			
		}

		public void Detach()
		{
			
		}
	}
}