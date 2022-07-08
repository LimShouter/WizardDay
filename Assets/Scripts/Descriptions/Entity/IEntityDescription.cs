using System.Collections.Generic;
using Descriptions.Entity;
using Descriptions.SO.Entity;
using Entity;
using UnityEngine;

namespace Descriptions
{
	public interface IEntityDescription
	{
		string EntityName { get; }

		EntityFacade prefab { get; }
		List<EntityDescriptionPartSO> Descritions { get; }
	}
}