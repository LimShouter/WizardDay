namespace Descriptions
{
	public interface IPlayerDescription
	{
		IMovementDescription MovementDescription { get; }
		ICameraDescription CameraDescription { get; }
	}
}