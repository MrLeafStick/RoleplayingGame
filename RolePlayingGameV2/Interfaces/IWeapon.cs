namespace RolePlayingGameV2.Interfaces
{
    public interface IWeapon : IItem
    {
        int MinWeaponDamage { get; }
        int MaxWeaponDamage { get; }
        int WeaponDamage { get; }
    }
}
