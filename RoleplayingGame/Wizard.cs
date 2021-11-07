namespace RoleplayingGame
{
    public class Wizard : BaseCharacter
    {
        #region Field Definitions

        #endregion

        #region Constructors
        public Wizard(string name,
                        int maxHitPoints,
                        int minDamage,
                        int maxDamage,
                        int maxStamina,
                        int staminaRegen,
                        int maxMana,
                        int ManaRegen)
            : base(name, maxHitPoints, minDamage, maxDamage, maxStamina, staminaRegen, maxMana, ManaRegen)
        {
        }
        #endregion

        #region Properties

        #endregion

        #region Override Properties
        protected override int DealDamageModifyChance
        {
            get
            {
                return 50;
            }
        }
        #endregion
    }
}
