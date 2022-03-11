using Unity.Mathematics;
using UnityEngine;

namespace Descriptions.SO
{
	[CreateAssetMenu(menuName = @"Descriptions/Entity/MovementDescription",fileName = "MovementDescription")]
	public class MovementDescriptionSo : ScriptableObject,IMovementDescription
	{
		[SerializeField]private float3 _direction;
		[SerializeField]private float _speed;
		public Vector3 Direction => _direction;
		public float Speed => _speed;
	}
}