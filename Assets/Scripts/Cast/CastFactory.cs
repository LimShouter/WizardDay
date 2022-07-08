using System;
using System.Collections.Generic;
using System.Linq;
using Descriptions.Cast;

namespace Cast
{
	public class CastFactory
	{
		private Dictionary<(Elements,Elements,Elements), string> Casts = new Dictionary<(Elements,Elements,Elements), string>();
		
		public CastFactory(List<ICastDescription> descriptions)
		{
			foreach (var castDescription in descriptions)
			{
				Casts.Add(((Elements, Elements, Elements)) GetTuple(castDescription.CastValues),castDescription.Prefab);
			}
		}
		
		
		private object GetTuple<T>(params T[] values)
		{
			Type genericType = Type.GetType("System.Tuple`" + values.Length);
			Type[] typeArgs = values.Select(_ => typeof(T)).ToArray();
			Type specificType = genericType.MakeGenericType(typeArgs);
			object[] constructorArguments = values.Cast<object>().ToArray();
			return Activator.CreateInstance(specificType, constructorArguments);
		}
	}
}