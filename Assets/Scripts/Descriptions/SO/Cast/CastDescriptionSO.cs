using System;
using System.Collections.Generic;
using Cast;
using Descriptions.Cast;
using UnityEngine;

namespace Descriptions.SO
{
	[CreateAssetMenu(fileName = "CastDescription", menuName = "Descriptions/CastDescription")]
	public class CastDescriptionSO : ScriptableObject,ICastDescription
	{
		[SerializeField] private List<Elements> _castValues;
		[SerializeField] private string _prefab;

		public List<Elements> CastValues => _castValues;
		public string Prefab => _prefab;
	}
}