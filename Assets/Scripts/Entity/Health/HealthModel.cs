using Descriptions.Entity;

namespace Entity.Health
{
	public class HealthModel
	{
		private readonly IEntityHealthDescription _description;

		public HealthModel(IEntityHealthDescription description)
		{
			_description = description;
		}
	}
}