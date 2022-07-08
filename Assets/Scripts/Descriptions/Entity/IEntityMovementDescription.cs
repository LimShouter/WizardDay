namespace Descriptions.Entity
{
	public interface IEntityMovementDescription 
	{
		float JumpForce { get; }
		float Speed { get; }
		float RotationSpeed { get; }
	}
}