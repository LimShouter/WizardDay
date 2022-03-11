using UnityEngine;

namespace Descriptions.SO
{
	[CreateAssetMenu(menuName = @"Descriptions\Player\CameraDescription", fileName = "CameraDescription")]
	public class CameraDescriptionSo : ScriptableObject, ICameraDescription
	{
		[SerializeField] private float _minY;
		[SerializeField] private float _minZ;
		[SerializeField] private float _maxY;
		[SerializeField] private float _maxZ;
		[SerializeField] private float _sensitivity;

		public float MinY => _minY;
		public float MinZ => _minZ;
		public float MaxY => _maxY;
		public float MaxZ => _maxZ;
		public float Sensitivity => _sensitivity;
	}
}