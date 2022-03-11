using System.Collections.Generic;

namespace UnityTemplateProjects.Utilities
{
	public class Engine
	{
		private List<ISystem> _systems = new List<ISystem>();
		private List<ISystem> _removedSystems = new List<ISystem>();

		public void Add(ISystem system)
		{
			_systems.Add(system);
		}

		public void Remove(ISystem system)
		{
			_systems.Remove(system);
		}

		public void Update(float deltaTime)
		{
			foreach (var removedSystem in _removedSystems)
			{
				if (_systems.Contains(removedSystem))
				{
					_systems.Remove(removedSystem);
				}
			}
			_removedSystems.Clear();

			foreach (var system in _systems)
			{
				system.Update(deltaTime);
			}
		}

		public void Clear()
		{
			foreach (var system in _systems)
			{
				if (!_removedSystems.Contains(system))
				{
					_removedSystems.Add(system);
				}
			}
		}
	}
}