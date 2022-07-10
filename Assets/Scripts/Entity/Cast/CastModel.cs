using Descriptions.Entity;

namespace Entity.Cast
{
	public class CastModel
	{
		public readonly IEntityCastDescription CastDescription;

		public CastModel(IEntityCastDescription castDescription)
		{
			CastDescription = castDescription;
		}
	}
}