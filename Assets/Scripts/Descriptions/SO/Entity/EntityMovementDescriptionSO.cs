using Descriptions.Entity;
using Descriptions.SO.Entity;
using UnityEngine;

namespace Descriptions
{
	[CreateAssetMenu(fileName = "EntityMovementDescription",
		menuName = "Descriptions/Entity/Parts/MovementDescription")]
	public class EntityMovementDescriptionSO : EntityDescriptionPartSO, IEntityMovementDescription
	{
		[SerializeField] private float _jumpForce;
		[SerializeField] private float _speed;
		[SerializeField] private float _rotationSpeed;
		public float JumpForce => _jumpForce;
		public float Speed => _speed;
		public float RotationSpeed => _rotationSpeed;
	}
}