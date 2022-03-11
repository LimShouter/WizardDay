using UnityEngine;

namespace Descriptions
{
	public interface IMovementDescription
	{
		Vector3 Direction { get; }
		float Speed { get; }
	}
}