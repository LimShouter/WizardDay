

using Cinemachine;
using UnityEngine;

namespace Descriptions.SO.Player
{
	[CreateAssetMenu(fileName = "PlayerDescription",menuName = "Descriptions/PlayerDescription")]
	public class PlayerDescriptionSO : ScriptableObject,IPlayerDescription
	{
		[SerializeField]private EntityDescriptionSO _entityDescription;
		[SerializeField]private CinemachineStateDrivenCamera _cameraPrefab;
		public IEntityDescription EntityDescription => _entityDescription;
		public CinemachineStateDrivenCamera CameraPrefab => _cameraPrefab;
	}
}