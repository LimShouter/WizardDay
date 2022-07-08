using Descriptions.Entity;
using Descriptions.SO.Entity;
using UnityEngine;

namespace Descriptions;

[CreateAssetMenu(fileName = "EntityHealthDescription",
	menuName = "Descriptions/Entity/Parts/HealthDescription")]
public class EntityHealthDescriptionSO : EntityDescriptionPartSO, IEntityHealthDescription
{
	[SerializeField] private int _health;
	
	public int Health => _health;
}