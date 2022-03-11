using System;
using Descriptions;
using UnityEngine;

namespace Player.Camera
{
	public class CameraModel
	{
		public event Action<float> OnMove;

		public readonly ICameraDescription Description;
		public CameraModel(ICameraDescription description)
		{
			Description = description;
		}
		public void Move(float yValue)
		{
			OnMove?.Invoke(yValue);
		}
	}
}