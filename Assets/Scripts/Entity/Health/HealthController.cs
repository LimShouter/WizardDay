namespace Entity.Health;

public class HealthController : IEntityController
{
	private readonly EntityFacade _entity;
	private readonly HealthModel _model;
	private readonly HealthView _view;

	public HealthController(EntityFacade entity, HealthModel model,HealthView view)
	{
		_entity = entity;
		_model = model;
		_view = view;
	}
	public void Attach()
	{
		
	}

	public void Detach()
	{
	}
}