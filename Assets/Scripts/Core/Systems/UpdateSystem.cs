using System.Collections.Generic;
using NotImplementedException = System.NotImplementedException;

namespace Core.Systems
{
	public class UpdateSystem : IUpdatable
	{
		public static UpdateSystem Instance = new UpdateSystem();
	
		private readonly List<IUpdatable> _updatables = new List<IUpdatable>();
		private readonly List<IUpdatable> _removed = new List<IUpdatable>();

		public void Add(IUpdatable updatable)
		{
			_updatables.Add(updatable);
		}

		public void Remove(IUpdatable updatable)
		{
			_removed.Add(updatable);
		}

		public void ManualUpdate(float deltaTime)
		{
			foreach (var removed in _removed)
			{
				_updatables.Remove(removed);
			}
		
			_removed.Clear();
		
			foreach (var updatable in _updatables)
			{
				updatable.ManualUpdate(deltaTime);
			}
		}
	}
}