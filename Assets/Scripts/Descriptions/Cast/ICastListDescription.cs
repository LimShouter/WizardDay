using System.Collections.Generic;

namespace Descriptions.Cast;

public interface ICastListDescription
{
	public List<ICastDescription> CastDescriptions { get; }
}