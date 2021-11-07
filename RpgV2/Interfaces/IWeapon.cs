namespace RpgV2.Interfaces
{
    public interface IWeapon : IItem
    {
        int MaxWeaponDamage { get; }
        int MinWeaponDamage { get; }
        int AverageWeaponDamage { get; }
    }
}