using Descriptions;
using UnityEngine.AddressableAssets;

namespace Entity
{
	public class EntityManager
	{
		private static EntityManager _instance;

		public static EntityManager Instance => _instance ??= new EntityManager();

		private readonly EntityFactory Factory = new EntityFactory();

		public EntityFacade Create(IEntityDescription description)
		{
			return Factory.Create(description);
		}

		public void Release(EntityFacade entity)
		{
		}
	}
}