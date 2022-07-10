using System.Collections.Generic;
using Descriptions.Cast;
using UnityEngine.AddressableAssets;

namespace Cast
{
	public class CastManager
	{
		private readonly CastFactory _factory;

		public CastManager(ICastListDescription description)
		{
			_factory = new CastFactory(description.CastDescriptions);
		}
	
		public async void Create(List<Elements> elementsArray)
		{
			var handle = Addressables.InstantiateAsync(_factory.GetCast(elementsArray));
		}

		private void Destroy()
		{
	
		}
	}
}