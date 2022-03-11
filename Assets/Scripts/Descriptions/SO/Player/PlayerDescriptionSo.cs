using UnityEngine;

namespace Descriptions.SO
{
	[CreateAssetMenu(menuName = @"Descriptions/Player/PlayerDescriptionSO",fileName = "PlayerDescription")]
	public class PlayerDescriptionSo : ScriptableObject,IPlayerDescription
	{

		[SerializeField] private MovementDescriptionSo _movementDescriptionSo;
		[SerializeField] private CameraDescriptionSo _cameraDescriptionSo;
		public IMovementDescription MovementDescription => _movementDescriptionSo;
		public ICameraDescription CameraDescription => _cameraDescriptionSo;
	}
}