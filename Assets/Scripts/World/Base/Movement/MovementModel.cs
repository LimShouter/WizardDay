using System;
using Descriptions;
using Unity.Mathematics;
using UnityTemplateProjects.Utilities;

namespace World.Base.Movement
{
	public class MovementModel : IForced
	{
		public event Action<float> OnUpdate;

		public readonly IMovementDescription Description;

		public MovementModel(IMovementDescription description)
		{
			Description = description;
		}


		public void Update(float deltaTime)
		{
			OnUpdate?.Invoke(deltaTime);
		}
	}
}