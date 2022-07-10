using Descriptions;
using Descriptions.Entity;
using Entity.Cast;
using Entity.Health;
using Entity.Movement;
using UnityEngine;

namespace Entity
{
	public class EntityFactory
	{
		public EntityFacade Create(IEntityDescription description)
		{
			var entity = GameObject.Instantiate(description.prefab);
			foreach (var descriptionPart in description.Descritions)
			{
				switch (descriptionPart)
				{
					case IEntityMovementDescription movementDescription:
						var movementModel = new MovementModel(movementDescription);
						var movementController = new MovementController(entity,movementModel,entity.GetComponent<MovementView>());
						entity.controllers.Add(movementController);
						break;
					case IEntityHealthDescription healthDescription:
						var healthModel = new HealthModel(healthDescription);
						var healthController = new HealthController(entity,healthModel,entity.GetComponent<HealthView>());
						entity.controllers.Add(healthController);
						break;
					case IEntityCastDescription castDescription:
						var castModel = new CastModel(castDescription);
						var castController = new CastController(entity,castModel,entity.GetComponent<CastView>());
						entity.controllers.Add(castController);
						break;
				}	
			}
			entity.OnInitialize();
			return entity;
		}
	}
}