using System.Collections.Generic;
using Descriptions.Cast;

namespace Cast
{
	public class CastFactory
	{
		private readonly Dictionary<(Elements?, Elements?, Elements?, Elements?), string> _casts =
			new Dictionary<(Elements?, Elements?, Elements?, Elements?), string>();

		public CastFactory(List<ICastDescription> descriptions)
		{
			foreach (var castDescription in descriptions)
			{
				_casts.Add(ParseElementsList(castDescription.CastValues), castDescription.Prefab);
			}
		}

		private (Elements?, Elements?, Elements?, Elements?) ParseElementsList(List<Elements> elementsList) =>
			elementsList.Count
				switch
				{
					1 => (elementsList[0], null, null, null),
					2 => (elementsList[0], elementsList[1], null, null),
					3 => (elementsList[0], elementsList[1], elementsList[2], null),
					4 => (elementsList[0], elementsList[1], elementsList[2], elementsList[3]),
					_ => (null, null, null, null)
				};

		public string GetCast(List<Elements> values) => _casts[ParseElementsList(values)];
	}
}