using System.Collections.Generic;
using Descriptions.Cast;
using UnityEngine;

namespace Descriptions.SO;

public class CastListDescriptionSO : ScriptableObject,ICastListDescription
{
	[SerializeField] private List<CastDescriptionSO> _castDescriptions;

	public List<ICastDescription> CastDescriptions => new List<ICastDescription>(_castDescriptions);
}