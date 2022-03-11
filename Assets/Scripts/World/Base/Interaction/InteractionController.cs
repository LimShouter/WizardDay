using UnityTemplateProjects.Utilities;

namespace UnityTemplateProjects.World.Base.Interaction
{
	public class InteractionController : IController
	{
		private readonly InteractionModel _model;
		private readonly InteractionComponent _component;

		public InteractionController(InteractionModel model,InteractionComponent  component)
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