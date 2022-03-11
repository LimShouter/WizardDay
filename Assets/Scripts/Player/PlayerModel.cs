using Descriptions;
using Player.Camera;
using UnityTemplateProjects.World.Base.Interaction;
using World.Base.Movement;

namespace Player
{
	public class PlayerModel
	{
		public MovementModel MovementModel;
		public InteractionModel InteractionModel;
		public CameraModel CameraModel;

		public PlayerModel(IPlayerDescription playerDescription)
		{
			MovementModel = new MovementModel(playerDescription.MovementDescription);
			CameraModel = new CameraModel(playerDescription.CameraDescription);
			// InteractionModel = new InteractionModel();
		}
	}
}