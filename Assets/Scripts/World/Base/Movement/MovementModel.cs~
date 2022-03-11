using System;
using Descriptions;
using Unity.Mathematics;
using UnityEngine;
using UnityTemplateProjects.Utilities;

namespace World.Base.Movement
{
	public class MovementModel : ISystem
	{
		public event Action<float> OnUpdate;

		public readonly IMovementDescription Description;
		public Vector3 Direction { get; private set; }

		public MovementModel(IMovementDescription description)
		{
			Description = description;
		}

		public void SetDirection(Vector3 direction)
		{
			Direction = direction;
		}
		public void Update(float deltaTime)
		{
			OnUpdate?.Invoke(deltaTime);
		}
	}
}