namespace Entity.Cast
{
	public class CastController : IEntityController
	{
		private readonly EntityFacade _entity;
		private readonly CastModel _model;
		private readonly CastView _view;

		public CastController(EntityFacade entity,CastModel model, CastView view)
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
}