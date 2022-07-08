using System.Collections.Generic;
using Cast;
using UnityEngine;

namespace Descriptions.Cast
{
	public interface ICastDescription
	{
		public List<Elements> CastValues { get; }
		public string Prefab { get; }
	}
}