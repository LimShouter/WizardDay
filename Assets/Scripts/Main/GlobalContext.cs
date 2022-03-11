using Descriptions;
using Player;
using UnityTemplateProjects.Utilities;

namespace Main
{
	public class GlobalContext
	{
		public readonly Engine Engine;
		public readonly PlayerModel PlayerModel;

		public GlobalContext(IDescriptionCollection descriptionCollection)
		{
			PlayerModel = new PlayerModel(descriptionCollection.PlayerDescription);
			Engine = new Engine();
		}
	}
}