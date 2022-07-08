using System;
using System.Collections.Generic;
using Descriptions;
using Entity.Movement;
using UnityEngine;

namespace Entity
{
	public class EntityFacade : MonoBehaviour
	{
		public event Action Destroyed; 
		[NonSerialized]public List<IEntityController> controllers = new List<IEntityController>();

		public void OnInitialize()
		{
			foreach (var controller in controllers)
			{
				controller.Attach();
			}
		}

		public void Destroy()
		{
			foreach (var controller in controllers)
			{
				controller.Detach();
			}
			controllers.Clear();
			Destroyed.Invoke();
		}

		public T GetController<T>()
		{
			foreach (var controller in controllers)
			{
				if (controller is T controller1)
				{
					return controller1;
				}
			}
			throw new NullReferenceException();
		}
	}
}