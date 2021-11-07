namespace RPG_V2.Interfaces
{
    public interface IWeapon : IItem
    {
        int MaxWeaponDamage { get; }
        int MinWeaponDamage { get; }

    }
}
