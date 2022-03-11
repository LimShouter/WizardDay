using System;
using UnityEngine;

namespace Player.Camera
{
	public class CameraModel
	{
		public event Action<float> OnMove;
		
		public float MinY;
		public float MinZ;
		public float MaxY;
		public float MaxZ;
		public float Sensitivity;

		public void Move(float yValue)
		{
			OnMove?.Invoke(yValue);
		}
	}
}