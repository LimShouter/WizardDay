using System.Collections.Generic;
using Descriptions.Entity;
using Descriptions.SO.Entity;
using Entity;
using UnityEngine;

namespace Descriptions
{
	[CreateAssetMenu(fileName = "EntityDescription", menuName = "Descriptions/Entity/EntityDescription")]
	public class EntityDescriptionSO : ScriptableObject, IEntityDescription
	{
		[SerializeField] public string _entityName;
		[SerializeField] public EntityFacade _prefab;
		[SerializeField] public List<EntityDescriptionPartSO> _descritions;

		public string EntityName =>_entityName;
		public EntityFacade prefab =>_prefab;
		public List<EntityDescriptionPartSO> Descritions => _descritions;
	}
}