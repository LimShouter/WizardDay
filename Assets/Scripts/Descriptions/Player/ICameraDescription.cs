namespace Descriptions
{
	public interface ICameraDescription
	{
		float MinY { get; }
		float MinZ { get; }
		float MaxY { get; }
		float MaxZ { get; }
		float Sensitivity { get; }
	}
}