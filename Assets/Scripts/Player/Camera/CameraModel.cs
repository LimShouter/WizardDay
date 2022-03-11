using System;
using Descriptions;
using UnityEngine;
using UnityTemplateProjects.Utilities;

namespace Player.Camera
{
	public class CameraModel
	{
		public event Action<float> OnMove;

		public readonly ICameraDescription Description;
		public float CurrentAngle;

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