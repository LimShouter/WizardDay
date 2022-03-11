using UnityEngine;

namespace Descriptions.SO
{
	[CreateAssetMenu(menuName = @"Descriptions\DescriptionCollection",fileName = "PlayerDescription")]
	public class DescriptionCollectionSo : ScriptableObject,IDescriptionCollection
	{
		[SerializeField]private PlayerDescriptionSo _playerDescription;
		
		public IPlayerDescription PlayerDescription => _playerDescription;
	}
}