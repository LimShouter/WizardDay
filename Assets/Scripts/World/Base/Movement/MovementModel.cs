using System;
using Unity.Mathematics;
using UnityTemplateProjects.Utilities;

namespace World.Base.Movement
{
	public class MovementModel : IForced
	{
		public event Action<float> OnUpdate;
		
		public float3 Direction;
		public float Speed;
		
		public void Update(float deltaTime)
		{
			OnUpdate?.Invoke(deltaTime);
		}
	}
}