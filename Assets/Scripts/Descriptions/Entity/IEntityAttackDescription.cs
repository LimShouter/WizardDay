namespace Descriptions.Entity
{
	public interface IEntityAttackDescription
	{
		public float AttackRange { get; }
		public int MinDamage { get; }
		public int MaxDamage { get; }
		public float LevelDamageMultiplier { get; }
		public float AttackSpeed { get; }

	}
}