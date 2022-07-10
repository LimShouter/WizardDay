using Descriptions;
using Descriptions.Entity;
using UnityEngine;

namespace Entity.Movement
{
	public class MovementModel
	{
		public readonly IEntityMovementDescription Description;

		public Vector3 Direction;

		public MovementModel(IEntityMovementDescription description)
		{
			Description = description;
		}
	}
}