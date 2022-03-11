using UnityTemplateProjects.Utilities;

namespace Player
{
	public class PlayerController : IController
	{
		private readonly PlayerModel _model;
		private readonly PlayerComponent _component;

		public PlayerController(PlayerModel model,PlayerComponent component)
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